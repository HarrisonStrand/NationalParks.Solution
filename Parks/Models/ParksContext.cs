using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<StatePark> StateParks { get; set; }
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NationalPark>()
                .HasData(
                    new NationalPark
                    {
						Id = 1,
                        Name = "Glacier Bay",
                        Location = "Alaska",
                        DateEstablished = "December 2, 1980",
                        Acres = "3,223,383.43 acres",
                        YearlyVisitors = "672087",
                        Description = "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles. When discovered in 1794 by George Vancouver, the entire bay was covered by ice, but the glaciers have since receded more than 65 miles"
                    },
                    new NationalPark
                    {
						Id = 2,
                        Name = "Petrified Forest",
                        Location = "Arizona",
                        DateEstablished = "December 9, 1962",
                        Acres = "221,390.21",
                        YearlyVisitors = "643,588 acres",
                        Description = "This portion of the Chinle Formation has a large concentration of 225-million-year-old petrified wood. The surrounding Painted Desert features eroded cliffs of red-hued volcanic rock called bentonite. Dinosaur fossils and over 350 Native American sites are also protected in this park."
                    },
                    new NationalPark
                    {
						Id = 3,
                        Name = "Mesa Verde",
                        Location = "Colorado",
                        DateEstablished = "June 29, 1906",
                        Acres = "138,999.37 acres",
                        YearlyVisitors = "556,203",
                        Description = "This area constitutes over 4,000 archaeological sites of the Ancestral Puebloan people, who lived here and elsewhere in the Four Corners region for at least 700 years. Cliff dwellings built in the 12th and 13th centuries include Cliff Palace, which has 150 rooms and 23 kivas, and the Balcony House, with its many passages and tunnels."
                    },
                    new NationalPark
                    {
						Id = 4,
                        Name = "Biscayne",
                        Location = "Florida",
                        DateEstablished = "June 28, 1980",
                        Acres = "172,971.11 acres",
                        YearlyVisitors = "708,522",
                        Description = "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs. Threatened animals include the West Indian manatee, American crocodile, various sea turtles, and peregrine falcon."
                    },
                    new NationalPark
                    {
						Id = 5,
                        Name = "Acadia",
                        Location = "Maine",
                        DateEstablished = "February 26, 1919",
                        Acres = "49,076.63 acres",
                        YearlyVisitors = "3,437,286",
                        Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats."
                    },
                    new NationalPark
                    {
						Id = 6,
                        Name = "Voyageurs",
                        Location = "Minnesota",
                        DateEstablished = "April 8, 1975",
                        Acres = "218,222.35 acres",
                        YearlyVisitors = "232,974",
                        Description = "This park protecting four lakes near the Canada–US border is a site for canoeing, kayaking, and fishing. The park also preserves a history populated by Ojibwe Native Americans, French fur traders called voyageurs, and gold miners. Formed by glaciers, the region features tall bluffs, rock gardens, islands, bays, and several historic buildings."
                    }
                );
            builder.Entity<StatePark>()
            .HasData(
                new StatePark
                {
					Id = 1,
					Name = "Fort Rock Cave",
					State = "Oregon",
					Region = "Central Oregon",
					Camping = "No",
					Description = "Fort Rock Cave was the site of the earliest evidence of human habitation in the US state of Oregon before the excavation of Paisley Caves. Fort Rock Cave featured numerous well-preserved sagebrush sandals, ranging from 9,000 to 13,000 years old. The cave is located approximately 1.5 miles (2.4 km) west of Fort Rock near Fort Rock State Natural Area in Lake County. Fort Rock Cave was declared a National Historic Landmark in 1961, and added to the National Register of Historic Places in 1966."
                },
                new StatePark
                {
					Id = 2,
					Name = "Smith Rock State Park",
					State = "Oregon",
					Region = "Central Oregon",
					Camping = "Yes",
					Description = "Smith Rock State Park is a state park located in central Oregon's High Desert near the communities of Redmond and Terrebonne. The day-use area of the park is open daily from dawn to dusk. The park also has a camping area as well that accommodates tent camping only. Its sheer cliffs of tuff and basalt are ideal for rock climbing of all difficulty levels. Smith Rock is generally considered the birthplace of modern American sport climbing, and is host to cutting-edge climbing routes. It is popular for sport climbing, traditional climbing, multi-pitch climbing, and bouldering."
                },
                new StatePark
                {
					Id = 3,
					Name = "Golden State Heritage Site",
					State = "Oregon",
					Region = "Southern Oregon",
					Camping = "Yes",
					Description = "Golden is an abandoned mining town located at Coyote Creek in Josephine County, Oregon, United States."
                },
                new StatePark
                {
					Id = 4,
					Name = "Sunset Bay State Park",
					State = "Oregon",
					Region = "South Coast",
					Camping = "Yes",
					Description = "Sunset Bay State Park is a state park in the U.S. state of Oregon. Administered by the Oregon Parks and Recreation Department, it is about 0.4 miles (0.6 km) south of Cape Arago Lighthouse and 2.5 miles (4.0 km) outside the town of Charleston on Coos Bay. The park offers a crescent shaped beach, tide pools, hiking trails and a year-round campground."
                },
                new StatePark
                {
					Id = 5,
					Name = "Sheridan State Scenic Corridor",
					State = "Oregon",
					Region = "Portland/Columbia Gorge",
					Camping = "No",
					Description = "Sheridan State Scenic Corridor is a state park in the Columbia River Gorge, west of Cascade Locks, Oregon. The 11-acre (4.5 ha) property, containing an old-growth forest, is located on the south side of Interstate 84 at approximately milepoint 42.5, and was not accessible by motor vehicle since I-84 was built in 1960. However, with the opening of the Eagle Creek-Cascade Locks segment of the Historic Columbia River Highway State Trail in 1998, it has become easily accessible by foot or bicycle. The park is on a triangular lot, completely surrounded by I-84 and the Mount Hood National Forest."
                },
                new StatePark
                {
					Id = 6,
					Name = "Oswald West State Park",
					State = "Oregon",
					Region = "North Coast",
					Camping = "No",
					Description = "Oswald West State Park is part of the state park system of the U.S. state of Oregon. It is located about 10 miles (16 km) south of the city of Cannon Beach, adjacent to Arch Cape, on the Pacific Ocean. The park covers 2,448 acres (9.91 km2), with many miles of hiking trails both inside the park grounds and linking to other parks and landmarks beyond."
                }
            );
        }
    }
}