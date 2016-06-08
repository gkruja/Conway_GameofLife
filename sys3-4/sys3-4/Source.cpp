//Yes, you need all this for memory leaks
#include <Windows.h>

#define _CRTDBG_MAP_ALLOC
#include <cstdlib>
#include <crtdbg.h>

#include <iostream>



using namespace std;

struct Info
{
	int age;
	char name[32];
};

int main(void)
{
	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);

	cout << "How many Record would you like? ";
	int count = -1;
	cin >> count;
	Info** temp;
	temp = new Info*[count];
	int i = 0;
	for (; i < count; ++i)
	{
		bool isDouble=false;
		char buffer[32];
		int j = 0;
		temp[i] = nullptr;
		temp[i] = new Info();
		cout << "\nEnter record " << i+1 << "'s age: ";

		cin >> temp[i]->age;

		cout << "\nEnter record " << i+1 << "'s name: ";


		cin.ignore(INT_MAX, '\n');
		cin.getline(buffer, 32, '\n');


		for (; j<i; ++j)
		{
			if (strcmp(buffer,temp[j]->name)==0)
			{
				cout << "Ther can be no douplicagtes";
				isDouble = true;
				delete temp[i];
				i--;
				
			}
		}
		if (isDouble == false)
		{
			strcpy_s(temp[i]->name, 32, buffer);
			isDouble = false;

		}
	}

	for (i = 0; i < count; ++i)
		cout << "\n\n\Record "<<i+1<<" - Name:" << temp[i]->name << "   Age: " << temp[i]->age << '\n';


	for (i = 0; i < count; ++i)
		delete temp[i];

	delete[] temp;



	system("pause");
	return 0;
}