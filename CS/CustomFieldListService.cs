using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraReports.UserDesigner;

namespace FieldListCustomIcons {

    class CustomFieldListService : FieldListService {
        int categoryNameIndex;

        public override int GetColumnImageIndex(PropertyDescriptor property,
            string dataMember, bool isList) {

            if (dataMember.Contains("CategoryName")) {
                return categoryNameIndex;
            }

            return base.GetColumnImageIndex(property, dataMember, isList);
        }

        public override DevExpress.Utils.ImageCollection CreateImageCollection() {
            ImageCollection result = base.CreateImageCollection();
            Image image =
                ResourceImageHelper.CreateBitmapFromResources("FieldListCustomIcons.DataPickerImage.png",
                typeof(CustomFieldListService).Assembly);

            result.AddImage(image);
            categoryNameIndex = result.Images.Count - 1;

            return result;
        }
    }
}
