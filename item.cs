namespace talkinggame
{
    public class item
    {
        private string itemName;
        private string itemNamePlural;
        private int itemValue;
        private itemType itemType;
        private appealType appealType;
        private string[] personalityLikeDislike;
        /* how like and dislike should work::
            1. biggest personality is default decider
            2. personal likes and dislikes override this
            3. when looking for a reason, default to personality UNLESS
                personal overrides, in which case you say::
                    "I usually hate this because _biggest personality reason_,
                        but I just LOVE pickles!"
                other wise, it's::
                    "sorry but I hate pickles! they are just too sour!"

        */
    }
    public class itemType
    {
        public string[] name = {
            "food", "clothing", "music", "furniture"
        };
    }
    public class appealType
    {
        public string[] name = {
            "adjective", "currentFurnitureSets", "currentFunAppliances",
            "currentWorkAppliances", "currentFlooring", "currentWallpaper",
            "hobby"
        };
    }
}