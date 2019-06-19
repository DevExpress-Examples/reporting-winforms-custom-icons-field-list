using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.Utils.Svg;

namespace FieldListCustomIcons {

    class CustomColumnImageProvider : DevExpress.Data.Browsing.Design.ColumnImageProvider {
        int categoryNameIndex;

        public override int GetColumnImageIndex(PropertyDescriptor property, 
            DevExpress.Data.Browsing.Design.TypeSpecifics specifics) {
            if (property.Name.Equals("CategoryName"))
                return categoryNameIndex;
            return base.GetColumnImageIndex(property, specifics);
        }
        public override SvgImageCollection CreateSvgImageCollection() {
            SvgImageCollection result = base.CreateSvgImageCollection();
            SvgImage image = new SvgImage(typeof(CustomColumnImageProvider), "FieldListCustomIcons.StarIcon.svg");

            result.Add(image);
            categoryNameIndex = result.Count - 1;

            return result;
        }
        
    }
}
