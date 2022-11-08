module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven actualMinutesInOven =
    expectedMinutesInOven - actualMinutesInOven

let preparationTimeInMinutes numberOfLayers = 2 * numberOfLayers

let elapsedTimeInMinutes numberOfLayers actualMinutesInOven =
    preparationTimeInMinutes numberOfLayers
    + actualMinutesInOven
