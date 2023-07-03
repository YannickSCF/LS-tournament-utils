namespace YannickSCF.LSTournaments.Utils {

    public enum Ranks { Novizio, Iniziato, Accademico, Cavaliere, MaestroDiScuola }

    public enum Styles {
        Form1, Form2, CourseY,
        Form3Long, Form4Long, Form5Long,
        Form3Dual, Form4Dual, Form5Dual,
        Form3Staff, Form4Staff, Form5Staff,
        Form6, Form7
    }
    public enum ParticipantBasicInfo { Country, Surname, Name, Rank, Styles, Academy, School, Tier };

    public enum PouleAssignType { OneByOne, PouleByPoule, Custom }

    public enum ParticipantSelectionType { Random, ByLevel, ByRank }
}
