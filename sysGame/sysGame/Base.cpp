#include "Utility.h"
#include "Base.h"


Base::Base(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)// : speed(_speed)  <-- Member Initializer List
{
	SetSpeed(_speed);
	SetColor(_color);
	SetModel(_model);
	SetX(_x);
	SetY(_y);
}
Base::Base()
{
}


Base::~Base()
{
}



void Base::SetModel(string _model)
{
	model = _model;


}

void Base::Render()
{

}

 void Base::Update()
{


}

void Base::WhoAmI()
{
	cout << "I am a vehicle.";
}