using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Xiv {
    public class FishingSpotCategory : XivRow {
        #region Properties
        public string Name { get { return AsString("Name"); } }
        #endregion

        #region Constructor
        public FishingSpotCategory(IXivSheet sheet, Ex.Relational.IRelationalRow sourceRow) : base(sheet, sourceRow) { }
        #endregion

        public override string ToString() {
            return Name;
        }
    }
}