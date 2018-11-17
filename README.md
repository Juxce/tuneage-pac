# tuneage-pac
This repo supports the development and testing of the Tuneage platform. Changes to any of the production pipelines are made and tested here and then deployed to other pipelines. 

For the purposes pipeline testing, the system being deployed is mocked so that similar bits are deployed by the pipeline. This allows pipeline development to proceed independently of application implementation and isolates the pipeline from application introduced side-effects. 

The first example is the tuneage-api Azure Function App deployment. In tuneage-pac the tuneage-api function app is mimiced by a canary  function app that implements a simple function similar to the tuneage-api function app. 

A noteable difference is that the mocks and mimics reside in a single repo whereas the tuneage artifacts are derived from several repos. This introduces a requirement that the pipelines be able to handle co-location with other pipelines. One solution is to establish a convention that the repo name also be the name of the root folder in the repo. 

The Tuneage pipelines are hosted in Azure Pipelines thanks to Microsoft and thier support of Open Source software.

[![Build Status](https://dev.azure.com/juxce/Tuneage/_apis/build/status/Juxce.tuneage-pac)](https://dev.azure.com/juxce/Tuneage/_build/latest?definitionId=6)
[![Deploy to Dev](https://vsrm.dev.azure.com/juxce/_apis/public/Release/badge/592a38d1-46db-4367-840d-e39c838dc135/1/1)](https://dev.azure.com/juxce/Tuneage/_release?view=mine&definitionId=1)

<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-sa/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">Creative Commons Attribution-ShareAlike 4.0 International License</a>.
