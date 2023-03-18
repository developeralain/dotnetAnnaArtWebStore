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
                    Title = "Perfect Autumn Day",
                    Description = "A perfect day",
                    Type = Classes.PaintingType.Landscape,
                    Subtype = Classes.PaintingSubtype.Fall,
                    Dimensions = "18 W x 18 H x 1.5 D in",
                    YearCreated = "2019",
                    ImageData = null,
                    OriginalPrice = 123000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Tropical Spell",
                    Description = "Rainforests are real cool",
                    Type = Classes.PaintingType.Rainforest,
                    Subtype = Classes.PaintingSubtype.None,
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2013",
                    ImageData = null,
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Flowers' Dialogue",
                    Description = "A perfect day",
                    Type = Classes.PaintingType.Rainforest,
                    Subtype = Classes.PaintingSubtype.None,
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2016",
                    ImageData = null,
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Secret Sunrise",
                    Description = "A perfect day",
                    Type = Classes.PaintingType.Rainforest,
                    Subtype = Classes.PaintingSubtype.None,
                    Dimensions = "36 W x 36 H x 1 D in",
                    YearCreated = "2017",
                    ImageData = null,
                    OriginalPrice = 371000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Seed of Spring",
                    Description = "An abstract marvel",
                    Type = Classes.PaintingType.Abstract,
                    Subtype = Classes.PaintingSubtype.None,
                    Dimensions = "30 W x 30 H x 1 D in",
                    YearCreated = "2009",
                    ImageData = null,
                    OriginalPrice = 173000,
                    IsOriginalAvailable = true,
                    IsPrintAvailable = true,
                },
                                new Painting()
                {
                    Title = "Late Summer Breeze",
                    Description = "A breezy abstract day",
                    Type = Classes.PaintingType.Abstract,
                    Subtype = Classes.PaintingSubtype.None,
                    Dimensions = "24 W x 24 H x 1 D in",
                    YearCreated = "2018",
                    ImageData = null,
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