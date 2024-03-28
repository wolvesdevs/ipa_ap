using System.Diagnostics;
using System.Text;

namespace AP.Domain.Algorithms;

public class H30Spring
{
    public int[] dv = [0, -2, -1, 1, 2, 2, 1, -1, -2];
    public int[] dh = [0, 1, 2, 2, 1, -1, -2, -2, -1];

    const int M = 4;
    const int N = 3;

    int m;
    int n;

    List<List<int>> board = new();
    bool printFlag;

    public void main()
    {
        m = M;
        n = N;

        for (int i = 0; i <= m; i++)
        {
            List<int> row = new();
            for (int j = 0; j <= n; j++)
            {
                row.Add(0);
            }
            board.Add(row);
        }

        printFlag = false;

        search(1, 1, 1);

        if (!printFlag)
        {
            Debug.WriteLine("解答がありません");
        }

    }

    private void search(int i, int v, int h)
    {
        if (v >= 1 && v <= m)
        {
            if (h >= 1 && h <= n)
            {
                if (board[v][h] == 0)
                {
                    board[v][h] = i;
                    if (i == m * n)
                    {
                        printBoard();
                        printFlag = true;
                    }
                    else
                    {
                        for (var j = 1; j <= 8; j++)
                        {
                            search(i + 1, v + dv[j], h + dh[j]);
                        }
                    }
                    board[v][h] = 0;
                }
            }
        }
    }

    private void printBoard()
    {
        StringBuilder sb = new();
        sb.AppendLine("--------");
        for (var v = 1; v <= m; v++)
        {
            List<string> line = [];
            for (var h = 1; h <= n; h++)
            {
                line.Add(board[v][h].ToString("00"));
            }

            sb.Append(string.Join(" ", line));
            if (v != m) // 最後の行でなければ改行を追加
            {
                sb.AppendLine();
            }
        }
        Debug.WriteLine(sb);
    }
}
