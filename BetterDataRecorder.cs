using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace BetterDataRecorder
{
    public class BetterDataRecorder : GH_Component
    {

        List<object> items = new List<object>();
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public BetterDataRecorder()
          : base("Better Data Recorder", "BRec",
            "A data recorder that can be enabled and reset via Grasshopper",
            "Params", "Util")
        {
        }

        public override Guid ComponentGuid => new Guid("fb04ddb9-aa17-45f1-8310-d52084adbb27");


        protected override System.Drawing.Bitmap Icon => Properties.Resources.BetterDataRecorder;


        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Item", "I", "The item to record.", GH_ParamAccess.item);
            pManager.AddBooleanParameter("Trigger", "T", "If true stores the item.", GH_ParamAccess.item, false);
            pManager.AddBooleanParameter("Reset", "R", "Clears the storage.", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("Items", "Is", "List of items", GH_ParamAccess.list);
        }




        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            object item = null;
            bool record = false;
            bool reset = false;


            if (!DA.GetData(0, ref item)) return;
            if (!DA.GetData(1, ref record)) return;
            if (!DA.GetData(2, ref reset)) return;

            if (item == null)
                return;

            if (reset)
            {
                items.Clear();
                return;
            }
            else if (record)
            {
                items.Add(item);
            }

            DA.SetDataList(0, items);

        }
    }
}
