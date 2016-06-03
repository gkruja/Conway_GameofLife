#include <iostream>;

using namespace std;

int main()
{



	cout << "How old are you? ";
	int age = 0;
	cin >> age;

	if (16 > age)
	{
		cout << "I'm sorry you're not old enough for this\n\n";
		system("pause");
		return 1;
	}
	else
	{
		cout << "well your old enough now\n\n";
		system("pause");
		return 0;
	}

	
}