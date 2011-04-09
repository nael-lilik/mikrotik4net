//*********************************************************
//  Autogenerated 9.4.2011 12:11:10
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
!re
=.id=*37
=name=Jenstejn AP
=target-addresses=10.43.101.1/32,10.43.109.1/32,10.43.100.161/32,10.43.102.82/32,10.43.109.65/32,10.43.109.129/32,10.43.109.192/32
=dst-address=0.0.0.0/0
=interface=all
=parent=none
=direction=both
=priority=8
=queue=default-small/default-small
=limit-at=0/0
=max-limit=20M/20M
=burst-limit=0/0
=burst-threshold=0/0
=burst-time=0s/0s
=total-queue=default-small
=total-max-limit=20000000
=invalid=false
=dynamic=false
=disabled=false
*/
namespace Tik4Net.Objects.Queue
{
    /// <summary>
    /// Represents one row in /queue/simple on mikrotik router.
    /// </summary>
    [TikEntity("/queue/simple", TikEntityEditMode.Editable)]    
    public sealed partial class QueueSimple: TikEntityBase
    {
        /// <summary>
        /// Row burst-limit property.
        /// </summary>
        [TikProperty("burst-limit", typeof(string), false, TikPropertyEditMode.Editable)]
        public string BurstLimit 
        { 
            get { return Properties.GetAsStringOrNull("burst-limit"); }
            set { Properties.SetAttribute("burst-limit", value); }
        }

        /// <summary>
        /// Row burst-threshold property.
        /// </summary>
        [TikProperty("burst-threshold", typeof(string), false, TikPropertyEditMode.Editable)]
        public string BurstThreshold 
        { 
            get { return Properties.GetAsStringOrNull("burst-threshold"); }
            set { Properties.SetAttribute("burst-threshold", value); }
        }        	

        /// <summary>
        /// Row burst-time property.
        /// </summary>
        [TikProperty("burst-time", typeof(string), false, TikPropertyEditMode.Editable)]
        public string BurstTime 
        { 
            get { return Properties.GetAsStringOrNull("burst-time"); }
            set { Properties.SetAttribute("burst-time", value); }
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
        /// Row direction property.
        /// </summary>
        [TikProperty("direction", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Direction 
        { 
            get { return Properties.GetAsStringOrNull("direction"); }
            set { Properties.SetAttribute("direction", value); }
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
        /// Row dynamic property.
        /// </summary>
        [TikProperty("dynamic", typeof(bool?), false, TikPropertyEditMode.Editable)]
        public bool? Dynamic 
        { 
            get { return Properties.GetAsBooleanOrNull("dynamic"); }
            set { Properties.SetAttribute("dynamic", value); }
        }        	

        /// <summary>
        /// Row interface property.
        /// </summary>
        [TikProperty("interface", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Interface 
        { 
            get { return Properties.GetAsStringOrNull("interface"); }
            set { Properties.SetAttribute("interface", value); }
        }        	

        /// <summary>
        /// Row invalid property.
        /// </summary>
        [TikProperty("invalid", typeof(bool?), false, TikPropertyEditMode.ReadOnly)]
        public bool? Invalid 
        { 
            get { return Properties.GetAsBooleanOrNull("invalid"); }
            // Property R/O set { Properties.SetAttribute("invalid", value); }
        }        	

        /// <summary>
        /// Row limit-at property.
        /// </summary>
        [TikProperty("limit-at", typeof(string), false, TikPropertyEditMode.Editable)]
        public string LimitAt 
        { 
            get { return Properties.GetAsStringOrNull("limit-at"); }
            set { Properties.SetAttribute("limit-at", value); }
        }        	

        /// <summary>
        /// Row max-limit property.
        /// </summary>
        [TikProperty("max-limit", typeof(string), false, TikPropertyEditMode.Editable)]
        public string MaxLimit 
        { 
            get { return Properties.GetAsStringOrNull("max-limit"); }
            set { Properties.SetAttribute("max-limit", value); }
        }        	

        /// <summary>
        /// Row name property.
        /// </summary>
        [TikProperty("name", typeof(string), true, TikPropertyEditMode.Editable)]
        public string Name 
        { 
            get { return Properties.GetAsString("name"); }
            set { Properties.SetAttribute("name", value); }
        }        	

        /// <summary>
        /// Row parent property.
        /// </summary>
        [TikProperty("parent", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Parent 
        { 
            get { return Properties.GetAsStringOrNull("parent"); }
            set { Properties.SetAttribute("parent", value); }
        }        	

        /// <summary>
        /// Row priority property.
        /// </summary>
        [TikProperty("priority", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? Priority 
        { 
            get { return Properties.GetAsInt64OrNull("priority"); }
            set { Properties.SetAttribute("priority", value); }
        }        	

        /// <summary>
        /// Row queue property.
        /// </summary>
        [TikProperty("queue", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Queue 
        { 
            get { return Properties.GetAsStringOrNull("queue"); }
            set { Properties.SetAttribute("queue", value); }
        }        	

        /// <summary>
        /// Row target-addresses property.
        /// </summary>
        [TikProperty("target-addresses", typeof(string), false, TikPropertyEditMode.Editable)]
        public string TargetAddresses 
        { 
            get { return Properties.GetAsStringOrNull("target-addresses"); }
            set { Properties.SetAttribute("target-addresses", value); }
        }        	

        /// <summary>
        /// Row total-max-limit property.
        /// </summary>
        [TikProperty("total-max-limit", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? TotalMaxLimit 
        { 
            get { return Properties.GetAsInt64OrNull("total-max-limit"); }
            set { Properties.SetAttribute("total-max-limit", value); }
        }        	

        /// <summary>
        /// Row total-queue property.
        /// </summary>
        [TikProperty("total-queue", typeof(string), false, TikPropertyEditMode.Editable)]
        public string TotalQueue 
        { 
            get { return Properties.GetAsStringOrNull("total-queue"); }
            set { Properties.SetAttribute("total-queue", value); }
        }        	
    }
    
    /// <summary>
    /// Represents list of rows in /queue/simple on mikrotik router.
    /// </summary>    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]    
    public sealed partial class QueueSimpleList : TikUnorderedList<QueueSimple>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueSimpleList"/> class.
        /// Default active session (<see cref="TikSession.ActiveSession"/> is used).
        /// </summary>
        public QueueSimpleList() 
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueSimpleList"/> class.
        /// </summary>
        /// <param name="session">The session used to access mikrotik.</param>
        public QueueSimpleList(TikSession session)
            : base(session)
        {
        }
    }           
}