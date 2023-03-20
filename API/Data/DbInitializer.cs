using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Paintings.Any()) return;

            var paintings = new List<Painting>
            {
                new Painting()
                {
                    Title = "Flowers' Dialogue",
                    Description = "A perfect day",
                    PaintingType = Classes.PaintingType.Rainforest,
                    PaintingSubtype = "",
                    Dimensions = "18 W x 18 H x 1.5 D in",
                    YearCreated = "2019",
                    ImageUrl = "../../../../public/images/Flowers' Dialogue.jpg",
                    OriginalPrice = 123000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Holland River",
                    Description = "Cool river in Ontario",
                    PaintingType = Classes.PaintingType.Landscape,
                    PaintingSubtype = Classes.PaintingSubtype.Summer,
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2013",
                    ImageUrl = "../../../../public/images/Holland River.jpg",
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Late Summer Breeze",
                    Description = "A perfect day",
                    PaintingType = Classes.PaintingType.Abstract,
                    PaintingSubtype = "",
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2016",
                    ImageUrl = "../../../../public/images/Late Summer Breeze.jpg",
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Morning in France",
                    Description = "Gloomy French morning in the country",
                    PaintingType = Classes.PaintingType.Landscape,
                    PaintingSubtype = Classes.PaintingSubtype.Summer,
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2017",
                    ImageUrl = "../../../../public/images/Morning in France.jpg",
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Pleasant Morning in France",
                    Description = "A gorgeous French morning",
                    PaintingType = Classes.PaintingType.Landscape,
                    PaintingSubtype = Classes.PaintingSubtype.Summer,
                    Dimensions = "30 W x 30 H x 1 D in",
                    YearCreated = "2009",
                    ImageUrl = "../../../../public/images/Pleasant Morning in France.jpg",
                    OriginalPrice = 173000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Poppy Field",
                    Description = "A breezy poppy field in France",
                    PaintingType = Classes.PaintingType.Landscape,
                    PaintingSubtype = Classes.PaintingSubtype.Summer,
                    Dimensions = "24 W x 24 H x 1 D in",
                    YearCreated = "2018",
                    ImageUrl = "../../../../public/images/Poppy Field.jpg",
                    OriginalPrice = 163000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },

            };
            
            // context.AddRange(paintings); // alternative way to add our above paintings to the database table 

            // iterates over paintings list and adds each one to our database context class for EF
            foreach (var painting in paintings)
            {
                context.Paintings.Add(painting);
            }

            context.SaveChanges();

        }
          
    }
}