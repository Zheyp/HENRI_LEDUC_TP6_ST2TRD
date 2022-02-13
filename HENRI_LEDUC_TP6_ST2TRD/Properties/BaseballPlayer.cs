using System;
using System.Runtime.Remoting.Channels;

namespace HENRI_LEDUC_TP6_ST2TRD.Properties
{
    abstract class BaseballPlayer
    {
        protected string _Team;
        protected string _Name;

        protected BaseballPlayer(string teamName, string name)
        {
            _Team = teamName;
            _Name = name;
        }
        

        public abstract void Swing();
        public abstract string GetTeam();
        public abstract string GetName();
    }

    class Fieldplayer : BaseballPlayer
    {
        public override void Swing()
        {
            Console.WriteLine(this.GetTeam() + " " + this.GetName() +  " swing ! it's a Home Run !");
        }

        public override string GetTeam()
        {
            return _Team;
        }

        public override string GetName()
        {
            return _Name;
        }

        public Fieldplayer(string teamName, string name) : base(teamName, name)
        {
        }
    }

    class Pitcher : BaseballPlayer
    {
        public Pitcher(string teamName, string name) : base(teamName, name)
        {
        }

        public override void Swing()
        {
            Console.WriteLine(this.GetTeam() + " Pitcher " +  this.GetName() +  " swing !  but it doesn't go far...");
        }

        public override string GetTeam()
        {
            return _Team;
        }

        public override string GetName()
        {
            return _Name;
        }

        public void Pitch()
        {
            Console.WriteLine(this.GetTeam() + " Pitcher " +  this.GetName() +  " throw the ball ! 150Km/H !");
        }
    }
        
}