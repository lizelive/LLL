namespace BGI
{
    public class Action
    {
        public string name;
        public float cost;
        public Relationship effect;

        public static Action[] Actions = {
        new Action{
            name = "build",
            effect = new Relationship
            {
                love = 1,
            }
        },
         new Action
        {
             name = "smite",
            effect = new Relationship
            {
                fear = 1,
                faith = 1,
                love = -1,
            }
        }
        };

    }
}
