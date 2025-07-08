// Fill out your copyright notice in the Description page of Project Settings.

#include "ONNXRuntime.h"

void FONNXRuntimeModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module

	Ort::InitApi();
	OrtEnvironment = Ort::Env();
}

void FONNXRuntimeModule::ShutdownModule()
{
	// Nothing to do here...
}

IMPLEMENT_MODULE(FONNXRuntimeModule, ONNXRuntime)
