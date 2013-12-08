//#pragma strict
//
//function Start () {
//
//}
//
//function Update () {
//
//}
//
//#pragma strict
//
//var INPUT = {
//    UP: 'w',
//    DOWN: 'x',
//    RIGHT: 'd',
//    LEFT: 'a',
//    UPRIGHT: 'e',
//    UPLEFT: 'q',
//    DOWNRIGHT: 'c',
//    DOWNLEFT: 'z'
//}
//
//function Map() {
//    this.zones = [];
//}
//Map.prototype.addZone = function(zone) {
//    this.zones.push(zone);
//}
//
//function Zone(x, y, z) {
//    this.x = x;
//    this.y = y;
//    this.z = z;
//    this.neighborhood = new Neighborhood();
//}
//
//function Neighborhood() {
//    // do nothing
//}
//
//function initMap() {
//    var map = new Map();
//    
//    // First create zones and positions
//    map.zones[0] = new Zone(0,1);
//    
//    map.zones[0] = new Zone(7, 2, 1);
//    map.push(new Zone(17, 4)); // 1
//    map.push(new Zone(15, 2)); // 2
//    map.push(new Zone(8, 10)); // 3
//    // ...
//    
//    // Then hard code their relationship
//    map.zones[0].neighborhood[INPUT.UP] = map.zones[1];
//    map.zones[1].neighborhood[INPUT.DOWN] = map.zones[0];
//    
//    map.zones[0].neighborhood[INPUT.LEFT] = map.zones[2];
//    map.zones[2].neighborhood[INPUT.RIGHT] = map.zones[0];
//    
//    map.zones[0].neighborhood[INPUT.UPLEFT] = map.zones[3];
//    map.zones[3].neighborhood[INPUT.DOWNRIGHT] = map.zones[0];
//    
//    // Set a startzone
//    map.startZone = map.zones[0];
//}
