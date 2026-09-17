using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.Portal2Split.GameSpecific
{
    abstract class GameSupport
    {
        public string FirstMap { get; protected set; }
        public string LastMap { get; protected set; }

        // ticks to subtract
        public int StartOffsetTicks { get; protected set;  }
        public int EndOffsetTicks { get; protected set; }

        public GameTimingMethod GameTimingMethod { get; protected set; } = GameTimingMethod.EngineTicks;

        // which player properties should be updated
        private PlayerProperties _requiredProperties;
        public PlayerProperties RequiredProperties
        {
            get
            {
#if DEBUG
                // so DebugPlayerState() works
                return PlayerProperties.ALL;
#else
                return _requiredProperties;
#endif
            }
            set { _requiredProperties = value; }
        }

        // what kind of generic auto-start detection to use
        // must call base.OnUpdate
        private AutoStart _autoStartType;
        protected AutoStart AutoStartType
        {
            get { return _autoStartType; }
            set {
                if (value == AutoStart.Unfrozen)
                    this.RequiredProperties |= PlayerProperties.Flags;
                else if (value == AutoStart.ViewEntityChanged)
                    this.RequiredProperties |= PlayerProperties.ViewEntity;
                else if (value == AutoStart.ParentEntityChanged)
                    this.RequiredProperties |= PlayerProperties.ParentEntity;
                _autoStartType = value;
            }
        }

        protected bool IsFirstMap { get; private set; }
        protected bool IsLastMap { get; private set; }

        private bool _onceFlag;

        // called when attached to a new game process
        public virtual void OnGameAttached(GameState state) { }

        // called on the first tick when player is fully in the game (according to demos)
        public virtual void OnSessionStart(GameState state)
        {
            _onceFlag = false;

            this.IsFirstMap = state.CurrentMap == this.FirstMap;
            this.IsLastMap = !this.IsFirstMap && state.CurrentMap == this.LastMap;
        }

        // called when player no longer fully in the game (map changed, load started)
        public virtual void OnSessionEnd(GameState state) { }

        // called once per tick when player is fully in the game
        public virtual GameSupportResult OnUpdate(GameState state)
        {
            if (_onceFlag)
                return GameSupportResult.DoNothing;

            if (this.AutoStartType == AutoStart.Unfrozen
                && !state.PlayerFlags.HasFlag(FL.FROZEN)
                &&  state.PrevPlayerFlags.HasFlag(FL.FROZEN))
            {
                Debug.WriteLine("FL_FROZEN removed from player");
                _onceFlag = true;
                return GameSupportResult.PlayerGainedControl;
            }
            else if (this.AutoStartType == AutoStart.ViewEntityChanged
                && state.PrevPlayerViewEntityIndex != GameState.ENT_INDEX_PLAYER
                && state.PlayerViewEntityIndex == GameState.ENT_INDEX_PLAYER)
            {
                Debug.WriteLine("view entity changed to player");
                _onceFlag = true;
                return GameSupportResult.PlayerGainedControl;
            }
            else if (this.AutoStartType == AutoStart.ParentEntityChanged
                && state.PrevPlayerParentEntityHandle != -1
                && state.PlayerParentEntityHandle == -1)
            {
                Debug.WriteLine("player no longer parented");
                _onceFlag = true;
                return GameSupportResult.PlayerGainedControl;
            }

            return GameSupportResult.DoNothing;
        }

        public static GameSupport Select()
        {
            string[] optionNames = { "Portal 2 (July 2009)", "Portal 2 (Retail)", "Portal Stories: Mel", "Aperture Tag", "Portal", "The Flash Version Mappack"};
            Type[] optionClasses = { typeof(Portal2_2009), typeof(Portal2), typeof(PortalStoriesMel), typeof(ApertureTag), typeof(Portal), typeof(PortalTFV) };
            Form prompt = new Form()
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                MaximumSize = new Size(0, 0),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Game selection",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            FlowLayoutPanel flow = new FlowLayoutPanel()
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                MaximumSize = new Size(0, 0),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = false
            };
            Label descriptionLabel = new Label() { Left = 20, Top = 15, Text = "Which game will this be?", Width = 160, AutoSize = true };

            ListBox optionsList = new ListBox
            {
                Left = 20,
                Top = 40,
                Width = 160,
                Height = 160,
                SelectionMode = SelectionMode.One,
                DataSource = optionNames
            };

            Button confirmButton = new Button()
            {
                Anchor = AnchorStyles.Right,
                Text = "Proceed.",
                Width = 80,
                Height = 25,
                DialogResult = DialogResult.OK
            };

            optionsList.DoubleClick += (sender, e) => { if (optionsList.SelectedItem != null) prompt.DialogResult = DialogResult.OK; };
            confirmButton.Click += (sender, e) => { prompt.Close(); };

            flow.Controls.Add(descriptionLabel);
            flow.Controls.Add(optionsList);
            flow.Controls.Add(confirmButton);
            prompt.Controls.Add(flow);
            prompt.AcceptButton = confirmButton;

            if (prompt.ShowDialog() == DialogResult.OK && optionsList.SelectedItem != null)
            {
                return (GameSupport)System.Activator.CreateInstance(optionClasses[optionsList.SelectedIndex]);
            }

            return null;
        }

        protected enum AutoStart
        {
            None,
            Unfrozen,
            ViewEntityChanged,
            ParentEntityChanged
        }
    }

    enum GameSupportResult
    {
        DoNothing,
        PlayerGainedControl,
        PlayerLostControl
    }

    [Flags]
    enum PlayerProperties
    {
        Flags = (1 << 0),
        Position = (1 << 1),
        ViewEntity = (1 << 2),
        ParentEntity = (1 << 3),
        ALL = Flags | Position | ViewEntity | ParentEntity
    }
}
