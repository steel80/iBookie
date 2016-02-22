// Write your Javascript code.

/**
 *
 * Bootstrap one-page template with Parallax effect | Script Tutorials
 * http://www.script-tutorials.com/bootstrap-one-page-template-with-parallax-effect/
 *
 * Licensed under the MIT license.
 * http://www.opensource.org/licenses/mit-license.php
 * 
 * Copyright 2014, Script Tutorials
 * http://www.script-tutorials.com/
 */

$(document).ready(function () {

    // create a LatLng object containing the coordinate for the center of the map
    //var bounds = new google.maps.LatLng(46.8173701, 2.8105723, 6.48);
    var map;
    var bounds = new google.maps.LatLngBounds();

    // prepare the map properties
    var options = {
        //zoom: 10,
        //center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        //navigationControl: true,
        //mapTypeControl: false,
        scrollwheel: false
        //disableDoubleClickZoom: true
    };

    // initialize the map object
    map = new google.maps.Map(document.getElementById('google_map'), options);

    // Multiple Markers
    var markers = [
        ['Stade de France, Paris', 48.9244627, 2.3579705],
        ['Stade Vélodrome, Marseille', 43.271281, 5.395901],
        ['Parc Olympique Lyonnais, Lyon', 45.7652987, 4.979835],
        ['Stade Pierre Mauroy, Lille', 50.6119701, 3.1282959],
        ['Parc des Princes', 48.8414356, 2.2508547],
        ['Stade Matmut Atlantique', 44.897381, -0.563747],
        ['Stade Geoffroy-Guichard', 45.4607318, 4.3879222],
        ['Allianz Riviera', 43.705013, 7.1904569],
        ['Stade Bollaert-Delelis', 50.4328302, 2.8127158],
        ['Stadium de Toulouse', 43.5832972, 1.431854]
    ];

    // Info Window Content
    var infoWindowContent = [
        ['<div class="info">' +
        '<h3>Stade de France</h3>' +
        '<p>Club: none | Opening: 1998 | Capacity: 80,000 seats</p>' + '</div>'],
        ['<div class="info">' +
        '<h3>Stade Vélodrome</h3>' +
        '<p>Club: Olympique de Marseille | Opening: 1937 | Capacity: 67,000 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Parc Olympique Lyonnais</h3>' +
        '<p>Club: Olympique Lyonnais | Opening: 2016 | Capacity: 59,286 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Stade Pierre Mauroy</h3>' +
        '<p>Club: Lille OSC | Opening: 2012 | Capacity: 50,000 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Parc des Princes</h3>' +
        '<p>Club: Paris Saint-Germain FC | Opening: 1972 | Capacity: 48,527 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Stade Matmut Atlantique</h3>' +
        '<p>Club: Girondins de Bordeaux | Opening: 2015 | Capacity: 42,115 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Stade Geoffrey-Guichard</h3>' +
        '<p>Club: AS Saint-Etienne | Opening: 1931 | Capacity: 41,500 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Allianz Riviera</h3>' +
        '<p>Club: OGC Nice | Opening: 2013 | Capacity: 35,624 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Stade Bollaert-Delelis</h3>' +
        '<p>Club: RC Lens | Opening: 1934 | Capacity: 38,223 seats</p>' +
        '</div>'],
        ['<div class="info">' +
        '<h3>Stadium de Toulouse</h3>' +
        '<p>Club: Toulouse FC | Opening: 1938 | Capacity: 35,472</p>' +
        '</div>']
    ];

    // Display multiple markers on a map
    var infoWindow = new google.maps.InfoWindow(), marker, i;

    // Loop through our array of markers & place each one on the map  
    for (i = 0; i < markers.length; i++) {
        var position = new google.maps.LatLng(markers[i][1], markers[i][2]);
        bounds.extend(position);
        marker = new google.maps.Marker({
            position: position,
            map: map,
            title: markers[i][0]
        });

        // Allow each marker to have an info window    
        google.maps.event.addListener(marker, 'click', (function (marker, i) {
            return function () {
                infoWindow.setContent(infoWindowContent[i][0]);
                infoWindow.open(map, marker);
            }
        })(marker, i));

        // Automatically center the map fitting all markers on the screen
        map.fitBounds(bounds);
    }

    // Override our map zoom level once our fitBounds function runs (Make sure it only runs once)
    var boundsListener = google.maps.event.addListener((map), 'bounds_changed', function (event) {
        if (this.getZoom() > 14) {
            this.setZoom(14);
        }
        google.maps.event.removeListener(boundsListener);
    });
});