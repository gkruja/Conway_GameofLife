#include <iostream>;
#include <time.h>;

using namespace std;

int main()
{
	enum test  { Worrior,spy,assasin,archer };
	cout << "To roll a random character\n";
	system("pause");
	int rnd;
	srand(time(0));
	rnd = rand() % 4;

	switch (rnd)
	{
	case Worrior:
		cout << "Type: Warrior \nHP:\t93\nMP:\t1\n";
		break;
	case spy:
		cout << "Type: spy \nHP:\t23\nMP:\t1\n";
		break;
	case assasin:
		cout << "Type: assassin \nHP:\t50\nMP:\t50\n";
		break;
	case archer:
		cout << "Type: archer \nHP:\t23\nMP:\t75\n";
		break;
	default:
		break;
	}


	system("pause");
	return 0;
}