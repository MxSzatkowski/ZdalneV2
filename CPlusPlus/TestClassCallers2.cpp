#include "TestClassCallers2.h"

Ent *CreateTestClass()
{
	return new Ent();
}

void DisposeTestClass(Ent *pObject)
{
	
		delete pObject;

}

float CallAdd(Ent *pObject, float a, float b)
{
		pObject->Add(a, b);
		return a + b;
}