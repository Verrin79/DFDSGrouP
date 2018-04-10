﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DFDSGroup
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("e29a8148-c3d7-4c24-af80-10947be6d311", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DFDSGroupRepository repository.
        /// </summary>
        public static DFDSGroupRepository repo = DFDSGroupRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://prod.dfds-unified.com/en-gb/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://prod.dfds-unified.com/en-gb/", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DFDSFerriesLogisticsFreightEurop.SomeDivTag.MainMenuIconItem' at 38;66.", repo.DFDSFerriesLogisticsFreightEurop.SomeDivTag.MainMenuIconItemInfo, new RecordItemIndex(1));
            repo.DFDSFerriesLogisticsFreightEurop.SomeDivTag.MainMenuIconItem.Click("38;66");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DFDSFerriesLogisticsFreightEurop.SomeDivTag.Announcements' at 82;25.", repo.DFDSFerriesLogisticsFreightEurop.SomeDivTag.AnnouncementsInfo, new RecordItemIndex(2));
            repo.DFDSFerriesLogisticsFreightEurop.SomeDivTag.Announcements.Click("82;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'DFDSFerriesLogisticsFreightEurop.Grid.Announcements'.", repo.DFDSFerriesLogisticsFreightEurop.Grid.AnnouncementsInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DFDSFerriesLogisticsFreightEurop.Grid.AnnouncementsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk'.", repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.DanskInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.DanskInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.English'.", repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.EnglishInfo, new RecordItemIndex(5));
            Validate.Exists(repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.EnglishInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk' at 66;33.", repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.DanskInfo, new RecordItemIndex(6));
            repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk.Click("66;33");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk1'.", repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk1Info, new RecordItemIndex(7));
            Validate.Exists(repo.DFDSFerriesLogisticsFreightEurop.AnnouncementListFullWidth.Dansk1Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
