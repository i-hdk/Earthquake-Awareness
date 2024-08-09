const funFacts = [
    "did you know that … taiwan experiences on average approximately 100 earthquakes each day?",
    "taipei 101 is 1667 ft tall, yet survives major earthquakes. why?",
    "did you know that … There are 42 active faults in Taiwan. (From active fault map of Taiwan published by the Central Geological Survey)"
]
const funFactDisplay = document.getElementById("funFact");
funFactDisplay.innerText = funFacts[parseInt(Math.random()*3)];

