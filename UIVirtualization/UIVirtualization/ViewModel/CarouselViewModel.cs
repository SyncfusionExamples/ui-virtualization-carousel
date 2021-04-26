using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIVirtualization
{
    public class CarouselViewModel
    {
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
        public CarouselViewModel()
        {
            for (int i = 1; i < 25; i++)
            {
                ImageCollection.Add(new CarouselModel("Image" + i + ".jpg"));
            }

        }
    }
}
