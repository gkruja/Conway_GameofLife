#include <iostream>;
#include <time.h>;

using namespace std;
int main()
{
	cout << "Think of a yes/no question.\n\n";
	system("pause");
	srand(time(0));
	int rnd = rand() % 8;
	switch (rnd)
	{
	case 0:
	{
		cout << "Absolutely NOT! \n";
		break;
	}
	case 1:
	{
		cout << "No \n";
		break;
	}
	case 2:
	{
		cout << "I don’t think so… \n";
		break;
	}
	case 3:
	{
		cout << "Hmmm… maybe ? \n";
		break;
	}

	case 4:
	{
		cout << "I believe so… \n";
		break;
	}
	case 5:
	{
		cout << "Yes \n";
		break;
	}
	case 6:
	{
		cout << "Hell YES! \n";
		break;
	}
	case 7:
	{
		cout << "Absolutely NOT! \n";
		break;
	}
	default:
		break;
	}



	system("pause");
	return 0;
}