#include "stdafx.h"
#include "Vehicle.h"

int MenuRun();
void CleanUp(Vehicle* v);
int main()
{
	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);
	int menu = 0;

	Vehicle* v = new Vehicle(10, 10, 1, White, "<[|]>");

	// runs the menu Function;
	while (true)
	{
		menu = MenuRun();
		if (menu == 4) { CleanUp(v); return 0; }

		if (menu == 1) break;
	}



	Console::Clear();

	while (menu = 1)
	{

		if (GetAsyncKeyState(VK_ESCAPE))
			break;

		Console::Lock(true);
		
		system("cls");
		v->Move();
		v->Display();

		Console::Lock(false);
		Sleep(5);
	}


	CleanUp(v);
	cout << "\n\n\n";
	system("pause");

	return 0;
}






void CleanUp(Vehicle* v)
{
	delete v;
}

int MenuRun()
{
	bool loop = true;
	int menu = 0, run, x = 0;



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
				return 0;
			
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

