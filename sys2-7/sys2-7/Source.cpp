#include <iostream>;

using namespace std;

int main()
{
	cout << "What color Popsicle do you want from the freezer?\n"
		<< "1)  Red\n"
		<< "2)  Green\n"
		<< "3)  Blue\n"
		<< "13) Aquamabrown\n"
		<< "> ";
	int ans = -1;
		cin >> ans;
		switch (ans)
		{
		case 1:
		{
			cout << "you chose red\n";
			break;
		}
		case 2:
		{
			cout << "you chose Green\n";
			break;
		}
		case 3:
		{
			cout << "you chose Blue\n";
			break;
		}
		case 13:
		{
			cout << "you chose Aquamabrown\n";
			break;
		}
		default:
			break;
		}

	system("pause");
	return 0;
}