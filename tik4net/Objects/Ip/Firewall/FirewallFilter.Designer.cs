//*********************************************************
//  Autogenerated 9.4.2011 12:11:10
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
!re
=.id=*52
=chain=input
=action=drop
=protocol=tcp
=src-address-list=ATACKER
=dst-port=21-22
=invalid=false
=dynamic=false
=disabled=false
=comment=Drop all packets from atackers
*/
namespace Tik4Net.Objects.Ip.Firewall
{
    /// <summary>
    /// Represents one row in /ip/firewall/filter on mikrotik router.
    /// </summary>
    [TikEntity("/ip/firewall/filter", TikEntityEditMode.Editable)]    
    public sealed partial class FirewallFilter: TikEntityBase
    {
        /// <summary>
        /// Row action property.
        /// </summary>
        [TikProperty("action", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Action 
        { 
            get { return Properties.GetAsStringOrNull("action"); }
            set { Properties.SetAttribute("action", value); }
        }

        /// <summary>
        /// Row address-list property.
        /// </summary>
        [TikProperty("address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string AddressList 
        { 
            get { return Properties.GetAsStringOrNull("address-list"); }
            set { Properties.SetAttribute("address-list", value); }
        }        	

        /// <summary>
        /// Row address-list-timeout property.
        /// </summary>
        [TikProperty("address-list-timeout", typeof(string), false, TikPropertyEditMode.Editable)]
        public string AddressListTimeout 
        { 
            get { return Properties.GetAsStringOrNull("address-list-timeout"); }
            set { Properties.SetAttribute("address-list-timeout", value); }
        }        	

        /// <summary>
        /// Row comment property.
        /// </summary>
        [TikProperty("comment", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Comment 
        { 
            get { return Properties.GetAsStringOrNull("comment"); }
            set { Properties.SetAttribute("comment", value); }
        }        	

        /// <summary>
        /// Row connection-limit property.
        /// </summary>
        [TikProperty("connection-limit", typeof(string), false, TikPropertyEditMode.Editable)]
        public string ConnectionLimit 
        { 
            get { return Properties.GetAsStringOrNull("connection-limit"); }
            set { Properties.SetAttribute("connection-limit", value); }
        }        	

        /// <summary>
        /// Row content property.
        /// </summary>
        [TikProperty("content", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Content 
        { 
            get { return Properties.GetAsStringOrNull("content"); }
            set { Properties.SetAttribute("content", value); }
        }        	

        /// <summary>
        /// Row disabled property.
        /// </summary>
        [TikProperty("disabled", typeof(bool), true, TikPropertyEditMode.Editable)]
        public bool Disabled 
        { 
            get { return Properties.GetAsBoolean("disabled"); }
            set { Properties.SetAttribute("disabled", value); }
        }        	

        /// <summary>
        /// Row dst-address property.
        /// </summary>
        [TikProperty("dst-address", typeof(string), false, TikPropertyEditMode.Editable)]
        public string DstAddress 
        { 
            get { return Properties.GetAsStringOrNull("dst-address"); }
            set { Properties.SetAttribute("dst-address", value); }
        }        	

        /// <summary>
        /// Row dst-address-list property.
        /// </summary>
        [TikProperty("dst-address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string DstAddressList 
        { 
            get { return Properties.GetAsStringOrNull("dst-address-list"); }
            set { Properties.SetAttribute("dst-address-list", value); }
        }        	

        /// <summary>
        /// Row dst-port property.
        /// </summary>
        [TikProperty("dst-port", typeof(string), false, TikPropertyEditMode.Editable)]
        public string DstPort 
        { 
            get { return Properties.GetAsStringOrNull("dst-port"); }
            set { Properties.SetAttribute("dst-port", value); }
        }        	

        /// <summary>
        /// Row dynamic property.
        /// </summary>
        [TikProperty("dynamic", typeof(bool?), false, TikPropertyEditMode.ReadOnly)]
        public bool? Dynamic 
        { 
            get { return Properties.GetAsBooleanOrNull("dynamic"); }
            // Property R/O set { Properties.SetAttribute("dynamic", value); }
        }        	

        /// <summary>
        /// Row chain property.
        /// </summary>
        [TikProperty("chain", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Chain 
        { 
            get { return Properties.GetAsStringOrNull("chain"); }
            set { Properties.SetAttribute("chain", value); }
        }        	

        /// <summary>
        /// Row in-interface property.
        /// </summary>
        [TikProperty("in-interface", typeof(string), false, TikPropertyEditMode.Editable)]
        public string InInterface 
        { 
            get { return Properties.GetAsStringOrNull("in-interface"); }
            set { Properties.SetAttribute("in-interface", value); }
        }        	

        /// <summary>
        /// Row invalid property.
        /// </summary>
        [TikProperty("invalid", typeof(bool?), false, TikPropertyEditMode.Editable)]
        public bool? Invalid 
        { 
            get { return Properties.GetAsBooleanOrNull("invalid"); }
            set { Properties.SetAttribute("invalid", value); }
        }        	

        /// <summary>
        /// Row log-prefix property.
        /// </summary>
        [TikProperty("log-prefix", typeof(string), false, TikPropertyEditMode.Editable)]
        public string LogPrefix 
        { 
            get { return Properties.GetAsStringOrNull("log-prefix"); }
            set { Properties.SetAttribute("log-prefix", value); }
        }        	

        /// <summary>
        /// Row packet-mark property.
        /// </summary>
        [TikProperty("packet-mark", typeof(string), false, TikPropertyEditMode.Editable)]
        public string PacketMark 
        { 
            get { return Properties.GetAsStringOrNull("packet-mark"); }
            set { Properties.SetAttribute("packet-mark", value); }
        }        	

        /// <summary>
        /// Row protocol property.
        /// </summary>
        [TikProperty("protocol", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Protocol 
        { 
            get { return Properties.GetAsStringOrNull("protocol"); }
            set { Properties.SetAttribute("protocol", value); }
        }        	

        /// <summary>
        /// Row src-address property.
        /// </summary>
        [TikProperty("src-address", typeof(string), false, TikPropertyEditMode.Editable)]
        public string SrcAddress 
        { 
            get { return Properties.GetAsStringOrNull("src-address"); }
            set { Properties.SetAttribute("src-address", value); }
        }        	

        /// <summary>
        /// Row src-address-list property.
        /// </summary>
        [TikProperty("src-address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string SrcAddressList 
        { 
            get { return Properties.GetAsStringOrNull("src-address-list"); }
            set { Properties.SetAttribute("src-address-list", value); }
        }        	

        /// <summary>
        /// Row src-port property.
        /// </summary>
        [TikProperty("src-port", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? SrcPort 
        { 
            get { return Properties.GetAsInt64OrNull("src-port"); }
            set { Properties.SetAttribute("src-port", value); }
        }        	
    }
    
    /// <summary>
    /// Represents list of rows in /ip/firewall/filter on mikrotik router.
    /// </summary>    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]    
    public sealed partial class FirewallFilterList : TikList<FirewallFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallFilterList"/> class.
        /// Default active session (<see cref="TikSession.ActiveSession"/> is used).
        /// </summary>
        public FirewallFilterList() 
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallFilterList"/> class.
        /// </summary>
        /// <param name="session">The session used to access mikrotik.</param>
        public FirewallFilterList(TikSession session)
            : base(session)
        {
        }
    }           
}