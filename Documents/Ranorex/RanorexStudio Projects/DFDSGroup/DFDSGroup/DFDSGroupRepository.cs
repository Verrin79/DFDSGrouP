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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DFDSGroup
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DFDSGroupRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("d5ace215-054f-4368-948a-0cf858b02a42")]
    public partial class DFDSGroupRepository : RepoGenBaseFolder
    {
        static DFDSGroupRepository instance = new DFDSGroupRepository();
        DFDSGroupRepositoryFolders.DFDSFerriesLogisticsFreightEuropAppFolder _dfdsferrieslogisticsfreighteurop;
        DFDSGroupRepositoryFolders.ExplorerAppFolder _explorer;

        /// <summary>
        /// Gets the singleton class instance representing the DFDSGroupRepository element repository.
        /// </summary>
        [RepositoryFolder("d5ace215-054f-4368-948a-0cf858b02a42")]
        public static DFDSGroupRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DFDSGroupRepository() 
            : base("DFDSGroupRepository", "/", null, 0, false, "d5ace215-054f-4368-948a-0cf858b02a42", ".\\RepositoryImages\\DFDSGroupRepositoryd5ace215.rximgres")
        {
            _dfdsferrieslogisticsfreighteurop = new DFDSGroupRepositoryFolders.DFDSFerriesLogisticsFreightEuropAppFolder(this);
            _explorer = new DFDSGroupRepositoryFolders.ExplorerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d5ace215-054f-4368-948a-0cf858b02a42")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The DFDSFerriesLogisticsFreightEurop folder.
        /// </summary>
        [RepositoryFolder("1bc14bf2-f222-4bd2-9d2d-fb1a7218bac8")]
        public virtual DFDSGroupRepositoryFolders.DFDSFerriesLogisticsFreightEuropAppFolder DFDSFerriesLogisticsFreightEurop
        {
            get { return _dfdsferrieslogisticsfreighteurop; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("4f6146c1-0393-44b4-9954-09c59112e13b")]
        public virtual DFDSGroupRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class DFDSGroupRepositoryFolders
    {
        /// <summary>
        /// The DFDSFerriesLogisticsFreightEuropAppFolder folder.
        /// </summary>
        [RepositoryFolder("1bc14bf2-f222-4bd2-9d2d-fb1a7218bac8")]
        public partial class DFDSFerriesLogisticsFreightEuropAppFolder : RepoGenBaseFolder
        {
            DFDSGroupRepositoryFolders.SomeDivTagFolder _somedivtag;
            RepoItemInfo _freightshippingInfo;
            RepoItemInfo _porttoportfreightshippingsolutionsInfo;
            RepoItemInfo _thedfdsgroupInfo;

            /// <summary>
            /// Creates a new DFDSFerriesLogisticsFreightEurop  folder.
            /// </summary>
            public DFDSFerriesLogisticsFreightEuropAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DFDSFerriesLogisticsFreightEurop", "/dom[@domain='prod.dfds-unified.com']", parentFolder, 30000, null, false, "1bc14bf2-f222-4bd2-9d2d-fb1a7218bac8", "")
            {
                _somedivtag = new DFDSGroupRepositoryFolders.SomeDivTagFolder(this);
                _freightshippingInfo = new RepoItemInfo(this, "FreightShipping", ".//div[#'root']/div/div/div[1]/div/div/div[1]/nav/a[@title='Freight shipping']", 30000, null, "b87d8c4a-3430-465c-abd4-465e927c11c5");
                _porttoportfreightshippingsolutionsInfo = new RepoItemInfo(this, "PortToPortFreightShippingSolutions", ".//div[#'root']/div/div/div[4]/div/div/div[1]/div/div[1]//h1[@innertext~'^Port-to-port\\ freight\\ ship']", 30000, null, "07d5124e-51f7-4797-83a8-23508dfcce16");
                _thedfdsgroupInfo = new RepoItemInfo(this, "TheDFDSGroup", ".//div[#'root']/div/div/div[4]/div/div/div[1]/div/div[1]//h1[@innertext='The DFDS group']", 30000, null, "4dc28eec-40a9-4ab6-9186-0d22bd740d66");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1bc14bf2-f222-4bd2-9d2d-fb1a7218bac8")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1bc14bf2-f222-4bd2-9d2d-fb1a7218bac8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FreightShipping item.
            /// </summary>
            [RepositoryItem("b87d8c4a-3430-465c-abd4-465e927c11c5")]
            public virtual Ranorex.ATag FreightShipping
            {
                get
                {
                    return _freightshippingInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The FreightShipping item info.
            /// </summary>
            [RepositoryItemInfo("b87d8c4a-3430-465c-abd4-465e927c11c5")]
            public virtual RepoItemInfo FreightShippingInfo
            {
                get
                {
                    return _freightshippingInfo;
                }
            }

            /// <summary>
            /// The PortToPortFreightShippingSolutions item.
            /// </summary>
            [RepositoryItem("07d5124e-51f7-4797-83a8-23508dfcce16")]
            public virtual Ranorex.H1Tag PortToPortFreightShippingSolutions
            {
                get
                {
                    return _porttoportfreightshippingsolutionsInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The PortToPortFreightShippingSolutions item info.
            /// </summary>
            [RepositoryItemInfo("07d5124e-51f7-4797-83a8-23508dfcce16")]
            public virtual RepoItemInfo PortToPortFreightShippingSolutionsInfo
            {
                get
                {
                    return _porttoportfreightshippingsolutionsInfo;
                }
            }

            /// <summary>
            /// The TheDFDSGroup item.
            /// </summary>
            [RepositoryItem("4dc28eec-40a9-4ab6-9186-0d22bd740d66")]
            public virtual Ranorex.H1Tag TheDFDSGroup
            {
                get
                {
                    return _thedfdsgroupInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The TheDFDSGroup item info.
            /// </summary>
            [RepositoryItemInfo("4dc28eec-40a9-4ab6-9186-0d22bd740d66")]
            public virtual RepoItemInfo TheDFDSGroupInfo
            {
                get
                {
                    return _thedfdsgroupInfo;
                }
            }

            /// <summary>
            /// The SomeDivTag folder.
            /// </summary>
            [RepositoryFolder("9617a521-9795-42f6-895a-e4812049c2a4")]
            public virtual DFDSGroupRepositoryFolders.SomeDivTagFolder SomeDivTag
            {
                get { return _somedivtag; }
            }
        }

        /// <summary>
        /// The SomeDivTagFolder folder.
        /// </summary>
        [RepositoryFolder("9617a521-9795-42f6-895a-e4812049c2a4")]
        public partial class SomeDivTagFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aboutdfdsInfo;
            RepoItemInfo _logisticssolutionsInfo;
            RepoItemInfo _mainmenuwrapperInfo;

            /// <summary>
            /// Creates a new SomeDivTag  folder.
            /// </summary>
            public SomeDivTagFolder(RepoGenBaseFolder parentFolder) :
                    base("SomeDivTag", ".//div[#'root']/div/div/div[1]", parentFolder, 30000, null, false, "9617a521-9795-42f6-895a-e4812049c2a4", "")
            {
                _aboutdfdsInfo = new RepoItemInfo(this, "AboutDFDS", ".//nav/a[@title='About DFDS']/div[@innertext='About DFDS']", 30000, null, "33c97bfe-f30e-4c91-accc-af161ffd51c1");
                _logisticssolutionsInfo = new RepoItemInfo(this, "LogisticsSolutions", ".//nav/a[@title='Logistics solutions']/div[@innertext='Logistics solutions']", 30000, null, "96fed249-3005-40cd-8469-3643fa161371");
                _mainmenuwrapperInfo = new RepoItemInfo(this, "MainMenuWrapper", "div/div/div[1]", 30000, null, "def6922d-e206-4e17-85d4-e30b2825926b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9617a521-9795-42f6-895a-e4812049c2a4")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9617a521-9795-42f6-895a-e4812049c2a4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AboutDFDS item.
            /// </summary>
            [RepositoryItem("33c97bfe-f30e-4c91-accc-af161ffd51c1")]
            public virtual Ranorex.DivTag AboutDFDS
            {
                get
                {
                    return _aboutdfdsInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The AboutDFDS item info.
            /// </summary>
            [RepositoryItemInfo("33c97bfe-f30e-4c91-accc-af161ffd51c1")]
            public virtual RepoItemInfo AboutDFDSInfo
            {
                get
                {
                    return _aboutdfdsInfo;
                }
            }

            /// <summary>
            /// The LogisticsSolutions item.
            /// </summary>
            [RepositoryItem("96fed249-3005-40cd-8469-3643fa161371")]
            public virtual Ranorex.DivTag LogisticsSolutions
            {
                get
                {
                    return _logisticssolutionsInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The LogisticsSolutions item info.
            /// </summary>
            [RepositoryItemInfo("96fed249-3005-40cd-8469-3643fa161371")]
            public virtual RepoItemInfo LogisticsSolutionsInfo
            {
                get
                {
                    return _logisticssolutionsInfo;
                }
            }

            /// <summary>
            /// The MainMenuWrapper item.
            /// </summary>
            [RepositoryItem("def6922d-e206-4e17-85d4-e30b2825926b")]
            public virtual Ranorex.DivTag MainMenuWrapper
            {
                get
                {
                    return _mainmenuwrapperInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The MainMenuWrapper item info.
            /// </summary>
            [RepositoryItemInfo("def6922d-e206-4e17-85d4-e30b2825926b")]
            public virtual RepoItemInfo MainMenuWrapperInfo
            {
                get
                {
                    return _mainmenuwrapperInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("4f6146c1-0393-44b4-9954-09c59112e13b")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _ranorexstudio1runningwindowInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "4f6146c1-0393-44b4-9954-09c59112e13b", "")
            {
                _ranorexstudio1runningwindowInfo = new RepoItemInfo(this, "RanorexStudio1RunningWindow", "container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[@accessiblename~'^RanorexStudio\\ -\\ 1\\ running']", 30000, null, "9e09276d-6180-4e9d-8837-fe3bb4832342");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4f6146c1-0393-44b4-9954-09c59112e13b")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4f6146c1-0393-44b4-9954-09c59112e13b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RanorexStudio1RunningWindow item.
            /// </summary>
            [RepositoryItem("9e09276d-6180-4e9d-8837-fe3bb4832342")]
            public virtual Ranorex.Button RanorexStudio1RunningWindow
            {
                get
                {
                    return _ranorexstudio1runningwindowInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RanorexStudio1RunningWindow item info.
            /// </summary>
            [RepositoryItemInfo("9e09276d-6180-4e9d-8837-fe3bb4832342")]
            public virtual RepoItemInfo RanorexStudio1RunningWindowInfo
            {
                get
                {
                    return _ranorexstudio1runningwindowInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}