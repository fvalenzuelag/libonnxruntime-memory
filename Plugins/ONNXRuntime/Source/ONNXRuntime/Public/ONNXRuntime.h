// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "Modules/ModuleManager.h"

#if PLATFORM_IOS
THIRD_PARTY_INCLUDES_START
#include "onnxruntime_cxx_api.h"
THIRD_PARTY_INCLUDES_END
#endif

class FONNXRuntimeModule : public IModuleInterface
{

public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

private:
	Ort::Env OrtEnvironment{nullptr};
};
