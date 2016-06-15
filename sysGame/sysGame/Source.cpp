#include "Utility.h"
#include "Base.h"
#include "Player.h"
#include "Obstacle.h"
#include "Game.h"
 

int MenuRun();
void CleanUp(Base* v);
int main()
{
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


	population.push_back(new Player(50, 15, 2, White, "<[|]>"));

	// runs the menu Function;
	while (true)
	{
		menu = MenuRun();
		if (menu == 4) { CleanUp(population[0]); return 0; }

		if (menu == 1) 
			break;
	}



	Console::Clear();

	Game::Run(population);




	CleanUp(population[0]);
	cout << "\n\n\n";
	system("pause");

	return 0;
}






void CleanUp(Base* v)
{
	delete v;
}

int MenuRun()
{
	bool loop = true;
	int menu = 0, x = 0;



	while (loop)
	{
		Console::SetCursorPosition(4, 0); cout << "1) PLAY";
		Console::SetCursorPosition(4, 1);  cout << "2) Output";
		Console::SetCursorPosition(4, 2);  cout << "3) ...";
		Console::SetCursorPosition(4, 3); cout << "4) ...";
		Console::SetCursorPosition(4, 4); cout << "Quit Program";

		system("pause>nul"); // the >nul bit causes it the print no message

		if (GetAsyncKeyState(VK_DOWN) && x != 4) //down button pressed
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
				Console::SetCursorPosition(20, 16);
				cout << "You chose Output...     ";
				break;
			}

			case 2:
			{
				Console::SetCursorPosition(20, 16);
				cout << "You chose Option 3...     ";
				break;
			}

			case 3:
			{
				Console::SetCursorPosition(20, 16);
				cout << "You chose Option 4...     ";
				break;
			}

			case 4:
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

