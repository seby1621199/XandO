namespace Xand0
{
    internal class Game
    {
        public string test = "ddd";
        
       private Coord[] arr = new Coord[10];
        public void add(int nr, int x, int y)
        {
            if (nr % 2 == 0)
            {
                arr[x * 3 + y + 1].player = "x";
                //  MessageBox.Show(x + " " + y + " poz " + t);
            }
            else
            {
                arr[x * 3 + y + 1].player = "o";
                // MessageBox.Show(x + " " + y + " poz " + t);
            }
        }
        public void clear()
        {
            for (int i = 1; i <= 9; i++)
                arr[i].player = null;

        }
        public string win()
        {
            if (arr[1].player == "o" && arr[2].player == "o" && arr[3].player == "o" || arr[4].player == "o" && arr[5].player == "o" && arr[6].player == "o" || arr[7].player == "o" && arr[8].player == "o" && arr[9].player == "o" || arr[1].player == "o" && arr[4].player == "o" && arr[7].player == "o" || arr[2].player == "o" && arr[5].player == "o" && arr[8].player == "o" || arr[3].player == "o" && arr[6].player == "o" && arr[9].player == "o" || arr[1].player == "o" && arr[5].player == "o" && arr[9].player == "o" || arr[3].player == "o" && arr[5].player == "o" && arr[7].player == "o")
            {
                return "o";
            }
            if (arr[1].player == "x" && arr[2].player == "x" && arr[3].player == "x" || arr[4].player == "x" && arr[5].player == "x" && arr[6].player == "x" || arr[7].player == "x" && arr[8].player == "x" && arr[9].player == "x" || arr[1].player == "x" && arr[4].player == "x" && arr[7].player == "x" || arr[2].player == "x" && arr[5].player == "x" && arr[8].player == "x" || arr[3].player == "x" && arr[6].player == "x" && arr[9].player == "x" || arr[1].player == "x" && arr[5].player == "x" && arr[9].player == "x" || arr[3].player == "x" && arr[5].player == "x" && arr[7].player == "x")
            {
                return "x";
            }
            return "none";
        }
        public bool check_empty(int x, int y)
        {
            if (arr[x * 3 + y + 1].player ==null)
                return true;
            else
                return false;

        }

    }


    struct Coord
    {
        public string player;
    }
}
