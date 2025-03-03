﻿namespace NBA_FINAL_PROJECT.Model
{

    public class JugadorUnico
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int? height_feet { get; set; }
        public int? height_inches { get; set; }
        public string last_name { get; set; }
        public string? position { get; set; }
        public Team4 team { get; set; }
        public int? weight_pounds { get; set; }
    }

    public class Team4
    {
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
    }

}
