$(document).ready(function () {
    // Asynchronously Load the map API 
    var script = document.createElement('script');
    script.src = "http://maps.googleapis.com/maps/api/js?sensor=false&callback=initialize";
    document.body.appendChild(script);

    var map;
    var bounds = new google.maps.LatLngBounds();
    var mapOptions = {
        mapTypeId: 'roadmap'
    };

    //australia latitude = -25.66846297, longitude = 135.21972656, sealevel = 194m

    map = new google.maps.Map(document.getElementById("mapcanvas"), mapOptions);
    map.setCenter(new GLatLng(-25.66846297, 135.21972656), 3);
    map.setTilt(45);
});