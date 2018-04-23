using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraReports.UserDesigner;

namespace FieldListCustomIcons {

    class CustomColumnImageProvider : DevExpress.Data.Browsing.Design.ColumnImageProvider {
        int categoryNameIndex;

        public override int GetColumnImageIndex(PropertyDescriptor property, 
            DevExpress.Data.Browsing.Design.TypeSpecifics specifics) {
            if (property.Name.Equals("CategoryName"))
                return categoryNameIndex;
            return base.GetColumnImageIndex(property, specifics);
        }
        public override DevExpress.Utils.ImageCollection CreateImageCollection() {
            ImageCollection result = base.CreateImageCollection();
            Image image =
                ResourceImageHelper.CreateBitmapFromResources("FieldListCustomIcons.DataPickerImage.png",
                typeof(CustomColumnImageProvider).Assembly);

            result.AddImage(image);
            categoryNameIndex = result.Images.Count - 1;

            return result;
        }
    }
}
