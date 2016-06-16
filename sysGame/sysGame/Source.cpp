#include "Utility.h"
#include "Base.h"
#include "Player.h"
#include "Obstacle.h"
#include "Game.h"
#include <mciapi.h>
#include <Windows.h>
#include <MMSystem.h> 

//these two headers are already included in the <Windows.h> header
#pragma comment(lib, "Winmm.lib")

int MenuRun();
void CleanUp(vector<Base*> _pop);


int main()
{
	//char* WAV = "C://Users/gkruja/Documents/GitHub/Conway_wpf/sysGame/sysGame/music.wav";// cow.wav is a piano song in hard drive 
	//sndPlaySound((LPWSTR)WAV, SND_ASYNC);
	 int LBsize = 10;
	PlaySound(L"music.wav", NULL, SND_ASYNC);

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
		menu = MenuRun();
		if (menu == 4) { CleanUp(population); return 0; }

		if (menu == 1)
			Game::Run(population, LBsize);
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

int MenuRun()
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

			switch (menu)
			{

			case 0:
				return 1;
			
			case 1:
			{
				int temp=0;
				Console::SetCursorPosition(20, 16);
				cout << "How Large would you like the Leader board to be? (min of 5)";
				cin >> temp;
				return temp;
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

