using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AnimalKingdomSimulator.Observer;
using AnimalKingdomSimulator.Environments;
using AnimalKingdomSimulator.BoardState;
using AnimalKingdomSimulator.Memento;

namespace AnimalKingdomSimulator
{
    public partial class AnimalKingdomWorld : Form, Originator
    {
        // "PROTOTYPE" Pattern*
        static Bear bear = new Bear(5, 9, 7, new MoveBehaviors.Walk(), new FightBehaviors.Maul());
        static Lion lion = new Lion(8, 7, 8, new MoveBehaviors.Leap(), new FightBehaviors.Bite());
        static Tiger tiger = new Tiger(9, 6, 7, new MoveBehaviors.Leap(), new FightBehaviors.Swipe());
        static Bunny bunny = new Bunny(4, 9, 10, new MoveBehaviors.Hop(), new FightBehaviors.NoFight());

        State noWorldState;
        State worldRunningState;
        State worldPausedState;

        private static AnimalKingdomWorld instance;

        public WorldStatistics ws = new WorldStatistics();
        MoveClockCounter moveCounter;

        public PictureBox[,] world;
        public GridObject[,] occupant;
        public bool paused = false;
        Thread controller;

        Image waterImg = AnimalKingdomSimulator.Properties.Resources.water;
        Image fruitImg = AnimalKingdomSimulator.Properties.Resources.fruit;
        Image plantImg = AnimalKingdomSimulator.Properties.Resources.plant;

        private bool hasSaved = false;

        public int WorldWidth
        {
            get
            {
                return world.GetLength(0);
            }
        }

        public int WorldHeight
        {
            get
            {
                return world.GetLength(1);
            }
        }

        public static AnimalKingdomWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimalKingdomWorld();
                }
                return instance;
            }
        }

        public AnimalKingdomWorld()
        {
            InitializeComponent();
            WorldStatpropertyGrid.SelectedObject = ws;
            generateGrid(80);
            instance = this;
            
            moveCounter = new MoveClockCounter(1000);
            EnviromentFactory er = new EnviromentFactory();
            moveCounter.registerObserver(er);
            controller = new Thread(new ThreadStart(moveCounter.Start));


            noWorldState = new NoWorldState(this);
            worldRunningState = new WorldRunningState(this);
            worldPausedState = new WorldPausedState(this);

            state = noWorldState;
        }

        /**
         * Generates Grid
         */
        public void generateGrid(int gridSize)
        {
            
            occupant = new GridObject[gridSize/8, gridSize/8];
            world = new PictureBox[gridSize / 8, gridSize / 8];

            //initilize world with blank pictureBoxes
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new PictureBox();
                    world[x, y].BorderStyle = BorderStyle.FixedSingle;
                    world[x, y].Location = new System.Drawing.Point(gridSize * (x), gridSize * (y));
                    //determine size of grids
                    world[x, y].ClientSize = new Size(gridSize, gridSize);
                    Console.WriteLine(x + "," + y);

                }
            }

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    this.Controls.Add(world[x, y]);
                }
            }
        }

        //test
        public void generateEnviroment()
        {
            //reset stats
            ws = new WorldStatistics();
            WorldStatpropertyGrid.SelectedObject = ws;

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    world[x, y].Image = element(x,y);
                }
            }
        }


        public Image element(int x, int y)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 20);

            Thread.Sleep(25);

            if (randomNumber == 0)
            {
                Lion lionClone = (Lion)lion.clone();
                moveCounter.registerObserver((Observer.Observer)lionClone);
                occupant[x, y] = lionClone;
                ws.lionCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 1)
            {
                Bear bearClone = (Bear)bear.clone();
                moveCounter.registerObserver((Observer.Observer)bearClone);
                occupant[x, y] = bearClone;
                ws.bearCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 2)
            {
                Tiger tigerClone = (Tiger)tiger.clone();
                moveCounter.registerObserver((Observer.Observer)tigerClone);
                occupant[x, y] = tigerClone;
                ws.tigerCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 3)
            {
                Bunny bunnyClone = (Bunny)bunny.clone();
                moveCounter.registerObserver((Observer.Observer)bunnyClone);
                occupant[x, y] = bunnyClone;
                ws.bunnyCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 4)
            {
                occupant[x, y] = new Plant(0, 1, 0);
                ws.plantCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Environments.Environment)occupant[x, y]).getImage();
            }
            if (randomNumber == 5)
            {
                occupant[x, y] = new Fruit(1, 0, 0);
                ws.fruitCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Environments.Environment)occupant[x, y]).getImage();
            }
            if (randomNumber == 6)
            {
                occupant[x, y] = new Water(0, 0, 1);
                ws.waterCount++;
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Environments.Environment)occupant[x, y]).getImage();
            }
            if (randomNumber == 7)
            {
                Snake snake = new Snake(4, 11);
                ReptileAdapter rep = new ReptileAdapter(snake);
                ws.snakeCount++;
                moveCounter.registerObserver((Observer.Observer)rep);
                occupant[x, y] = rep;

                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 8)
            {
                Croc croc = new Croc(11, 9);
                ReptileAdapter rep = new ReptileAdapter(croc);
                ws.crocCount++;
                occupant[x, y] = rep;
                moveCounter.registerObserver((Observer.Observer)rep);
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }

            if (randomNumber == 9)
            {
                Gecko gecko = new Gecko(11, 9);
                ReptileAdapter rep = new ReptileAdapter(gecko);
                ws.geckoCount++;
                occupant[x, y] = rep;
                moveCounter.registerObserver((Observer.Observer)rep);
                occupant[x, y].xCordinate = x;
                occupant[x, y].yCordinate = y;
                return ((Animal)occupant[x, y]).getImage();
            }


            else return null;
        }

        public void empty()
        {
            for (int y = 0; y < occupant.GetLength(1); y++)
            {
                for (int x = 0; x < occupant.GetLength(0); x++)
                {
                    if ((occupant[x, y] == null))
                    {
                        Console.WriteLine("empty at" + x + "," + y);
                    }
                    if (occupant[x, y] is Bear)
                    {
                        Console.WriteLine("bear found at" + x + "," + y);
                    }
                }
            }
        }

        private void GenerateWorldBtn_Click(object sender, EventArgs e)
        {
            state.GenerateWorld();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            state.Pause();
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            state.Start();
        }

        public void generateWorld()
        {
            if (!controller.ThreadState.ToString().Contains(ThreadState.Suspended.ToString()))
            {
                controller.Abort();
            }
            controller = new Thread(new ThreadStart(moveCounter.Start));
            generateEnviroment();
            WorldStatpropertyGrid.Refresh();
            controller.Start();
        }

        public void pauseWorld()
        {
            controller.Suspend();
        }

        public void resumeWorld()
        {
            controller.Resume();
        }

        public void saveWorld()
        {
            AnimalKingdomCareTaker.Instance.Memento = CreateMemento();
            hasSaved = true;
        }

        public void loadWorld()
        {
            if (hasSaved)
            {
                SetMemento(AnimalKingdomCareTaker.Instance.Memento);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            controller.Abort();
            base.OnClosed(e);
        }

        public void MakeMove(Animal animal, int CordX, int CordY)
        {
            if (occupant[CordX, CordY] == null)
            {
                occupant[CordX, CordY] = animal;
                occupant[animal.xCordinate, animal.yCordinate] = null;
                world[animal.xCordinate, animal.yCordinate].Image = null;
                world[CordX, CordY].Image = animal.getImage();
                animal.xCordinate = CordX; animal.yCordinate = CordY;
            }
            else if (occupant[CordX, CordY].GetType().BaseType.Equals(typeof(Animal)))
            {
                if (animal.performFight() > ((Animal)occupant[CordX, CordY]).performFight())
                {
                    RemoveAnimalFromStatistics((Animal)occupant[CordX, CordY]);
                    moveCounter.removeObserver((Observer.Observer)occupant[CordX, CordY]);
                    occupant[CordX, CordY] = animal;
                    occupant[animal.xCordinate, animal.yCordinate] = null;
                    world[animal.xCordinate, animal.yCordinate].Image = null;
                    world[CordX, CordY].Image = animal.getImage();
                    animal.xCordinate = CordX; animal.yCordinate = CordY;
                }
                else //challenger loses on same value
                {
                    RemoveAnimalFromStatistics(animal);
                    moveCounter.removeObserver(animal);
                    occupant[animal.xCordinate, animal.yCordinate] = null;
                    world[animal.xCordinate, animal.yCordinate].Image = null;
                }
            }
            else
            //else if (occupant[CordX, CordY].GetType().BaseType.Equals(typeof(Environments.Environment)))
            {
                //TODO: EAT STUFF
                RemovePlantsFromStatistics(((Environments.Environment)occupant[CordX, CordY]).getType());
                animal.performEat((Environments.Environment)occupant[CordX, CordY]);
                occupant[CordX, CordY] = animal;
                occupant[animal.xCordinate, animal.yCordinate] = null;
                world[animal.xCordinate, animal.yCordinate].Image = null;
                world[CordX, CordY].Image = animal.getImage();
                animal.xCordinate = CordX; animal.yCordinate = CordY;
            }

            this.Invoke((MethodInvoker)delegate { WorldStatpropertyGrid.Refresh(); });
        }

        public void PutEnvironment(Environments.Environment environment, int CordX, int CordY)
        {
            if (occupant[CordX, CordY] == null)
            {
                AddPlantsToStatistics(environment.getType());
                occupant[CordX, CordY] = environment;
                world[CordX, CordY].Image = environment.getImage();
            }
        }

        public void RemoveAnimalFromStatistics(Animal animal)
        {
            Type type = animal.GetType();
            if (type.Equals(typeof(Bear)))
                ws.bearCount--;
            else if (type.Equals(typeof(Bunny)))
                ws.bunnyCount--;
            else if (type.Equals(typeof(Lion)))
                ws.lionCount--;
            else if (type.Equals(typeof(Tiger)))
                ws.tigerCount--;
            else if (type.Equals(typeof(ReptileAdapter)))
            {
                ReptileAdapter temp = (ReptileAdapter)animal;
                type = temp.type().GetType();
                if (type.Equals(typeof(Snake)))
                    ws.snakeCount--;
                else if (type.Equals(typeof(Gecko)))
                    ws.geckoCount--;
                else if (type.Equals(typeof(Croc)))
                    ws.crocCount--;
            }
    
        }

        public void RemovePlantsFromStatistics(string type)
        {
            if (type == Fruit.getStringType())
                ws.fruitCount--;
            else if (type == Plant.getStringType())
                ws.plantCount--;
            else if (type == Water.getStringType())
                ws.waterCount--;
        }

        public void AddPlantsToStatistics(string type)
        {
            if (type == Fruit.getStringType())
                ws.fruitCount++;
            else if (type == Plant.getStringType())
                ws.plantCount++;
            else if (type == Water.getStringType())
                ws.waterCount++;
        }

        public State state
        {
            get;
            set;
        }

        public State getNoWorldState
        {
            get { return noWorldState; }
        }

        public State getWorldRunningState
        {
            get { return worldRunningState; }
        }

        public State getWorldPausedState
        {
            get { return worldPausedState; } 
        }

        public String setWorldStatsText
        {
            set { WorldStatsGroupBox.Text = value; }
        }

        public Memento.Memento CreateMemento()
        {
            return (new AnimalKingdomMemento(occupant, ws, state, moveCounter));
        }

        public void SetMemento(Memento.Memento memento)
        {
            foreach (GridObject or in occupant)
            {
                if (or is Animal)
                {
                    moveCounter.removeObserver((Observer.Observer)or);
                    continue;
                }
                if (or is Environments.Environment)
                {
                    continue;
                }
            }

            occupant = new GridObject[this.WorldWidth, this.WorldHeight];
            //world = new PictureBox[this.WorldWidth / 8, this.WorldHeight / 8];

            for (int i = 0; i < this.WorldWidth; i++)
            {
                for (int j = 0; j < this.WorldHeight; j++)
                {
                    world[i, j].Image = null;
                }
            }

            foreach (GridObject or in ((AnimalKingdomMemento)memento).Occupants)
            {
                if (or is Animal)
                {
                    Animal mem = ((Animal)or).clone();
                    occupant[mem.xCordinate, mem.yCordinate] = mem;
                    moveCounter.registerObserver((Observer.Observer)mem);
                    world[mem.xCordinate, mem.yCordinate].Image = ((Animal)mem).getImage();
                    continue;
                }
                if (or is Environments.Environment)
                {
                    Environments.Environment mem = ((Environments.Environment)or).clone();
                    occupant[mem.xCordinate, mem.yCordinate] = mem;
                    world[mem.xCordinate, mem.yCordinate].Image = ((Environments.Environment)or).getImage();
                    continue;
                }
            }

            this.ws = ((AnimalKingdomMemento)memento).WorldStatistics.clone();
        }

        private void saveMementoBtn_Click(object sender, EventArgs e)
        {
            state.Save();
        }

        private void loadMementoBtn_Click(object sender, EventArgs e)
        {
            state.Load();
        }
    }

    public class WorldStatistics
    {
        int _lionCount;
        int _tigerCount;
        int _bearCount;
        int _bunnyCount;
        int _plantCount;
        int _waterCount;
        int _fruitCount;
        int _snakeCount;
        int _geckoCount;
        int _crocCount;

        [Category("Animals")]
        [DisplayName("Lions")]
        public int lionCount
        {
            get { return _lionCount; }
            set { _lionCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Tigers")]
        public int tigerCount
        {
            get { return _tigerCount; }
            set { _tigerCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Bears")]
        public int bearCount
        {
            get { return _bearCount; }
            set { _bearCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Bunnies")]
        public int bunnyCount
        {
            get { return _bunnyCount; }
            set { _bunnyCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Snakes")]
        public int snakeCount
        {
            get { return _snakeCount; }
            set { _snakeCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Geckos")]
        public int geckoCount
        {
            get { return _geckoCount; }
            set { _geckoCount = value; }
        }

        [Category("Animals")]
        [DisplayName("Crocs")]
        public int crocCount
        {
            get { return _crocCount; }
            set { _crocCount = value; }
        }

        [Category("Resources")]
        [DisplayName("Plants")]
        public int plantCount
        {
            get { return _plantCount; }
            set { _plantCount = value; }
        }

        [Category("Resources")]
        [DisplayName("Water")]
        public int waterCount
        {
            get { return _waterCount; }
            set { _waterCount = value; }
        }

        [Category("Resources")]
        [DisplayName("Fruit")]
        public int fruitCount
        {
            get { return _fruitCount; }
            set { _fruitCount = value; }
        }


        public WorldStatistics clone()
        {
            return (WorldStatistics)this.MemberwiseClone();
        }
    }   
}
