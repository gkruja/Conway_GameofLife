#include "Utility.h"
#include "Base.h"
#include "Player.h"
#include "Obstacle.h"
#include "Game.h"
#include <mciapi.h>
#include <Windows.h>



int MenuRun(char FileName[32], char PlayerName[32],int& lbsize);
int SettingsMenu(char FileName[32], char PlayerName[32],int& lbsize);
void CleanUp(vector<Base*> _pop);


int main()
{
	char FileName[32] ="save";
	char PlayerName[32] ="player";

	 int LBsize = 10;
	 //music
	PlaySound(L"music.wav", NULL, SND_LOOP | SND_ASYNC);

	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);
	// Console stuff
	Console::SetWindowSize(100, 30);
	Console::SetBufferSize(100, 30);
	Console::EOLWrap(false);
	Console::CursorVisible(false);

	vector<Base*> population;
	int menu = 0;


	population.push_back(new Player(50, 15, 2, White, "T"));

	// runs the menu Function;
	while (true)
	{
		menu = MenuRun(FileName,PlayerName,LBsize);
		if (menu == 4) { CleanUp(population); return 0; }

		if (menu == 1)
			Game::Run(population, LBsize,FileName,PlayerName);
		if (menu > 4)
			LBsize = menu;




		Console::Clear();

		
	}



	CleanUp(population);
	cout << "\n\n\n";
	system("pause");

	return 0;
}






void CleanUp(vector<Base*> _pop)
{
	decltype(_pop.size()) i = 0;

	for ( ; i < _pop.size(); ++i)
		delete _pop[i];


}

int MenuRun(char FileName[32], char PlayerName[32],int& lbsize)
{
	bool loop = true;
	int menu = 0, x = 0;



	while (loop)
	{

		Console::SetCursorPosition(4, 0); cout << "1) PLAY";
		Console::SetCursorPosition(4, 1);  cout << "2) Settings";
		Console::SetCursorPosition(4, 2);  cout << "3) Help";
		Console::SetCursorPosition(4, 3); cout << "Quit Program";

		system("pause>nul"); // the >nul bit causes it the print no message

		if (GetAsyncKeyState(VK_DOWN) && x != 3) //down button pressed
		{
			Console::SetCursorPosition(0, x); cout << "  ";
			x++;
			Console::SetCursorPosition(0, x); cout << "->";
			menu++;
			continue;

		}

		if (GetAsyncKeyState(VK_UP) && x != 0) //up button pressed
		{
			Console::SetCursorPosition(0, x); cout << "  ";
			x--;
			Console::SetCursorPosition(0, x); cout << "->";
			menu--;
			continue;
		}

		if (GetAsyncKeyState(VK_RETURN)) { // Enter key pressed
			Console::Clear();

			switch (menu)
			{

			case 0:
				return 1;
			
			case 1:
			{
				int temp = SettingsMenu(FileName, PlayerName, lbsize);

				if (lbsize != temp)
					lbsize = temp;


			}

			case 2:
			{

				Console::SetCursorPosition(20, 17);
				cout << "avoid the Red player 'v'";
				Console::SetCursorPosition(20, 18);
				cout << "collect the '$' objects to increase your score";
				Console::SetCursorPosition(20, 19);
				break;
			}

			case 3:
			{
				Console::SetCursorPosition(20, 16);
				cout << "The program has now terminated!!";
				return 4;
			}


			}

		}

	}
	return 0;
}


int SettingsMenu(char FileName[32], char PlayerName[32],int& lbsize)
{
	bool loop = true;
	int menu = 0, x = 0;



	while (loop)
	{

		Console::SetCursorPosition(4, 0); cout << "LeaderBoard File Name";
		Console::SetCursorPosition(4, 1);  cout << "Leaderboard Size";
		Console::SetCursorPosition(4, 2); cout << "Go Back";

		system("pause>nul"); // the >nul bit causes it the print no message

		// check which arrow key is pressed and move the arrow selector a d incrment for the switch;
		if (GetAsyncKeyState(VK_DOWN) && x != 2) 
		{
			Console::SetCursorPosition(0, x); cout << "  ";
			x++;
			Console::SetCursorPosition(0, x); cout << "->";
			menu++;
			continue;

		}

		if (GetAsyncKeyState(VK_UP) && x != 0) 
		{
			Console::SetCursorPosition(0, x); cout << "  ";
			x--;
			Console::SetCursorPosition(0, x); cout << "->";
			menu--;
			continue;
		}

		if (GetAsyncKeyState(VK_RETURN)) { 
			Console::Clear();

			switch (menu)
			{

			case 0:
			{
			Console::SetCursorPosition(20, 16);
			cout << "Enter the LeaderBoard File Name:  ";
			cin >> FileName;
			cin.ignore(INT_MAX, '\n');
			
			}
			case 1:
			{
				int temp = 0;
				Console::SetCursorPosition(20, 16);
				cout << "How Large would you like the Leader board to be? (min of 5)";
				cin >> temp;
				cin.ignore(INT_MAX, '\n');
				return temp;
			}

			case 2:
			{
				Console::SetCursorPosition(20, 16);
				cout << "The program has now terminated!!";
				return 4;
			}


			}

		}

	}
	return 0;
}

