#include <iostream>;

using namespace std;

int main()
{
	cout << "Enter hour to convert to Pacific to Eastern?";
	int time = -1;
	while (true)
	{
		cin >> time;

		if (0 < time && time < 13)
		{
			if(time > 9)
			time -= 12;
			cout << "That would be " << time + 3 << "Eastern\n";
			break;
		}
		else
		{
			cout << "This is not valid\n";
		}
	}
	
	
	system("pause");
	return 0;
}