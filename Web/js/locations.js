/*
 * jVector Maps
 */ 

var markers = 
    [{ latLng: [31.2294198200 ,121.4789082700], name: 'ShangHai' }, 
        { latLng: [33.6101600000, 119.0159500000], name: 'HuaiAn' }, 
        { latLng: [39.9046900000, 116.4071700000], name: 'BeiJing' }, 
        { latLng: [22.5428600000, 114.0595600000], name: 'ShenZheng' }, 
        { latLng: [27.7254500000, 106.9272300000], name: 'ZunYi' }];

$(function() {
    "use strict";
    var $jvectormapDiv = $('#jvectormap');
    if ($jvectormapDiv.length && $.fn.vectorMap) {
        $jvectormapDiv.vectorMap({
            map: 'world_mill',
            zoomOnScroll: false,
            hoverOpacity: 0.7,
            regionStyle: {
                initial: {
                    fill: '#e3ecff',
                    "fill-opacity": 1,
                    "stroke-width": 0,
                },
                hover: {
                    fill: '#cfdcf7',
                    "fill-opacity": 1,
                    cursor: 'pointer'
                },
            },
            markerStyle: {
                initial: {
                    fill: '#2761d8',
                    stroke: '#2761d8'
                }
            },
            markers: markers
        });
    }
});