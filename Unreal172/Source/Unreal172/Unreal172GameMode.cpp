// Copyright Epic Games, Inc. All Rights Reserved.

#include "Unreal172GameMode.h"
#include "Unreal172Character.h"

AUnreal172GameMode::AUnreal172GameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = AUnreal172Character::StaticClass();	
}
