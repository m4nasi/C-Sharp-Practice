/*       -1 0 1
	*       *
	* * * * *
*/

# include<stdio.h>
# include<conio.h>
# include<stdlib.h>
# include<dos.h>

void main()
{
	int cx = 3, cy = 1, bx = 6, by = 25;
	char ch;
	int score = 0;
	int lives = 3;
	int d = 0;
start:
	clrscr();

	//Printing score
	gotoxy(34, 1);
	textcolor(CYAN);
	cprintf("Score: %d", score);

	gotoxy(34, 2);
	textcolor(GREEN);
	cprintf("Lives: %d", lives);

	//Printing Candy
	gotoxy(cx, cy);
	textcolor(YELLOW);
	cprintf("#");

	//Making left arm
	gotoxy(bx - 2, by - 1);
	textcolor(RED);
	cprintf("*");

	//Making right arm
	gotoxy(bx + 2, by - 1);
	textcolor(RED);
	cprintf("*");

	//Making base
	gotoxy(bx - 2, by);
	textcolor(RED);
	printf("*****");

	if (kbhit()) // kbhit = key board hit
	{
		ch = getch();
		switch (ch)
		{

			case 'a':
				bx--;
				break;

			case 'd':
				bx++;
				break;

			case 'x':
				exit(0);
				break;
		}
	}
	cy++; // candy movement command

	if (cy == 25)                         //    -1 <= x <= 1
	{
		d = cx - bx;
		if (-1 <= d && d <= 1)      // -1 <= x
									//   x <= 1
		{
			score++;
		}

		else
		{
			lives--;
			if (lives == 0)
			{
				clrscr();

				gotoxy(34, 13);
				textcolor(RED);
				cprintf("GAME OVER :(");

				gotoxy(34, 14);
				textcolor(CYAN);
				cprintf("Score: %d", score);

				gotoxy(34, 15);
				textcolor(BLUE);
				cprintf("Press any key to exit");

				getch();
				exit(0);
			}
		}

		cy = 1;
		cx = rand() % 20 + 1;

	}


	delay(100);

	goto start;



}