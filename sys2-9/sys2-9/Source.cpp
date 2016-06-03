#include <iostream>;

using namespace std;


int main()
{
	cout << "Difficulty Levels\n"
		<< "1)	Easy\n"
		<< "2)	Medium\n"
		<< "3)	Hard\n"
		<< "What’ll it be ?";
	int ans;
	cin >> ans;
	cout << "You’ll have to fight" << ans * 6 << "enemies! \n";




	system("pause");
	return 0;



}