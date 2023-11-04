#include <iostream>

extern "C" _declspec(dllexport) void SayHello();

void SayHello()
{
	std::cout << "Hello from CPP" << std::endl;
}