namespace AngularAppApi.Model
{
    public class FootballApiModel
    {
        public Stage[] Stages { get; set; }

        public class Stage
        {
            public string Sid { get; set; }
            public string Snm { get; set; }
            public string Scd { get; set; }
            public string Cid { get; set; }
            public string Cnm { get; set; }
            public string Csnm { get; set; }
            public string Ccd { get; set; }
            public string CompId { get; set; }
            public string CompN { get; set; }
            public string CompD { get; set; }
            public int Scu { get; set; }
            public string Ccdiso { get; set; }
            public int Chi { get; set; }
            public int Shi { get; set; }
            public string Sdn { get; set; }
            public Event[] Events { get; set; }
        }

        public class Event
        {
            public string Eid { get; set; }
            public Pids Pids { get; set; }
            public Sids Sids { get; set; }
            public string Tr1 { get; set; }
            public string Tr2 { get; set; }
            public string Trh1 { get; set; }
            public string Trh2 { get; set; }
            public string Tr1OR { get; set; }
            public string Tr2OR { get; set; }
            public T1[] T1 { get; set; }
            public T2[] T2 { get; set; }
            public string Eps { get; set; }
            public int Esid { get; set; }
            public int Epr { get; set; }
            public int Ecov { get; set; }
            public int Ern { get; set; }
            public string ErnInf { get; set; }
            public int Ewt { get; set; }
            public int Et { get; set; }
            public long Esd { get; set; }
            public long LuUT { get; set; }
            public long Eds { get; set; }
            public long Edf { get; set; }
            public int Eact { get; set; }
            public int EO { get; set; }
            public int IncsX { get; set; }
            public int ComX { get; set; }
            public int LuX { get; set; }
            public int StatX { get; set; }
            public int SubsX { get; set; }
            public int SDFowX { get; set; }
            public int SDInnX { get; set; }
            public int LuC { get; set; }
            public int Ehid { get; set; }
            public int Spid { get; set; }
            public Stg Stg { get; set; }
            public int Pid { get; set; }
        }

        public class Pids
        {
            public string _1 { get; set; }
            public string _6 { get; set; }
            public string _8 { get; set; }
            public string _12 { get; set; }
            public string _28 { get; set; }
            public string _32 { get; set; }
            public string _29 { get; set; }
        }

        public class Sids
        {
            public string _1 { get; set; }
            public string _6 { get; set; }
            public string _8 { get; set; }
            public string _12 { get; set; }
            public string _28 { get; set; }
            public string _32 { get; set; }
        }

        public class Stg
        {
            public string Sid { get; set; }
            public string Snm { get; set; }
            public string Scd { get; set; }
            public string Cid { get; set; }
            public string Cnm { get; set; }
            public string Csnm { get; set; }
            public string Ccd { get; set; }
            public string CompId { get; set; }
            public string CompN { get; set; }
            public string CompD { get; set; }
            public int Scu { get; set; }
            public string Ccdiso { get; set; }
            public int Chi { get; set; }
            public int Shi { get; set; }
            public string Sdn { get; set; }
        }

        public class T1
        {
            public string Nm { get; set; }
            public string ID { get; set; }
            public string Img { get; set; }
            public string NewsTag { get; set; }
            public string Abr { get; set; }
            public int tbd { get; set; }
            public int Gd { get; set; }
            public Pids1 Pids { get; set; }
            public string CoNm { get; set; }
            public string CoId { get; set; }
            public bool HasVideo { get; set; }
        }

        public class Pids1
        {
            public string[] _1 { get; set; }
            public string[] _6 { get; set; }
            public string[] _8 { get; set; }
            public string[] _12 { get; set; }
            public string[] _28 { get; set; }
            public string[] _30 { get; set; }
            public string[] _32 { get; set; }
        }

        public class T2
        {
            public string Nm { get; set; }
            public string ID { get; set; }
            public string Img { get; set; }
            public string NewsTag { get; set; }
            public string Abr { get; set; }
            public int tbd { get; set; }
            public int Gd { get; set; }
            public Pids2 Pids { get; set; }
            public string CoNm { get; set; }
            public string CoId { get; set; }
            public bool HasVideo { get; set; }
        }

        public class Pids2
        {
            public string[] _1 { get; set; }
            public string[] _6 { get; set; }
            public string[] _8 { get; set; }
            public string[] _12 { get; set; }
            public string[] _28 { get; set; }
            public string[] _30 { get; set; }
            public string[] _32 { get; set; }
        }
    }
}
