# UdonAirtime SwimSystem Integration
Integrates Airtime with [Hirabiki's SwimSystem](https://hirabiki.booth.pm/items/2127684) to prevent Airtime and SwimSystem from interfering with each other.

## Requirements
* Unity 2019.4.x
* VRCSDK3 (Minimum 3.0.9 from VCC)
* UdonSharp (Minimum 1.0.1 from VCC)
* [UdonAirtime](https://github.com/squiddingme/UdonAirtime) (Minimum 2.0)
* [Hirabiki's SwimSystem](https://hirabiki.booth.pm/items/2127684) (Minimum 2.0)
* (Optional) [CyanPlayerObjectPool](https://github.com/CyanLaser/CyanPlayerObjectPool)

## Download
Get it in the [releases](https://github.com/squiddingme/UdonAirtimeSwimSystem/releases).

## Basic Setup
1. Use [Creator Companion](https://vrchat.com/home/download) to create or upgrade project
3. Import UdonSharp to project using the [Creator Companion](https://vrchat.com/home/download)
4. (Optional) Import [CyanPlayerObjectPool](https://github.com/CyanLaser/CyanPlayerObjectPool/releases) to project to use the PooledPlayerController, which allows everyone to see each other's effects and sounds
5. Import UdonAirtime package to project
6. Import Hirabiki's SwimSystem package to project
7. Import UdonAirtimeSwimSystem package to project
8. Instead of using the Airtime and SwimSystem prefabs, use the combined **AirtimeWithObjectPoolAndSwimSystem** prefab or **AirtimeWithoutObjectPoolAndSwimSystem** prefab

## License
This work is licensed under the terms of the MIT license.