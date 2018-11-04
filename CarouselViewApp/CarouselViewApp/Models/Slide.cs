using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarouselViewApp.Models
{
    public class Slide
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class FakeSlideData
    {
        public ObservableCollection<Slide> Slides { get; set; }
        public FakeSlideData()
        {
            Slides = new ObservableCollection<Slide>
            {
                new Slide
                {
                    Name = "Slide 1",
                    ImageUrl = "https://sadin.ir/image/584/280/PostImage/Cover-08cceb83.jpg"
                },
                new Slide
                {
                    Name = "Slide 2",
                    ImageUrl = "https://sadin.ir/image/584/280/PostImage/Cover-7d6cc25e.png"
                },
                new Slide
                {
                    Name = "Slide 3",
                    ImageUrl = "https://sadin.ir/image/584/280/PostImage/SitemapGenerator-69f4da72.png"
                },
                new Slide
                {
                    Name = "Slide 4",
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/23c1dd13-333a-459e-9e23-c3784e7cb434/2016-06-02_1049.png"
                },
                new Slide
                {
                    Name = "Slide 5",
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png"
                },
                new Slide
                {
                    Name = "Slide 6",
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png"
                }
            };
        }
    }
}
