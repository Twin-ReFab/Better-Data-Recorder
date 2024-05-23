using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace BetterDataRecorder
{
    public class BetterDataRecorderInfo : GH_AssemblyInfo
    {
        public override string Name => "BetterDataRecorder";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("52bae62c-3f15-46f5-a49f-3bb1dcd1d101");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}