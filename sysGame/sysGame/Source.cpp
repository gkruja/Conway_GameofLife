#include "stdafx.h"
#include "Vehicle.h"

int main()
{
	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);
	

	Vehicle* v = new Vehicle(10, 10, 1, White, "<[|]>");

	while (true)
	{

	}







	while (true)
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


	delete v;
	
	cout << "\n\n\n";
	system("pause");

	return 0;
}

