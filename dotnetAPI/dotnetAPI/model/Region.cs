﻿namespace dotnetAPI.model {
    public class Region {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //navigation property
        public IEnumerable<Walk> Walks { get; set; }
    }
}
