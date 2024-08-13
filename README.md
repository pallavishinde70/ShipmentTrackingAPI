download this repository and use the command 'dotnet run' to run this application.

Then use postman application to view the output

http://localhost:5000/api/shipments/status?startDate=2023-04-30&endDate=2024-08-10

OUTPUT:

[
    {
        "trackingNumber": "9361210912402070562974",
        "shipmentDate": "2023-05-04T15:18:16",
        "latestShipmentStatus": "In Transit with carrier",
        "statusDate": "2023-05-14T05:01:42.043"
    },
    {
        "trackingNumber": "9400136106074818355209",
        "shipmentDate": "2023-05-12T07:20:20",
        "latestShipmentStatus": "In Transit with carrier",
        "statusDate": "2023-05-14T05:16:47.807"
    },
    {
        "trackingNumber": "9200190287129905127608",
        "shipmentDate": "2023-04-30T21:44:02",
        "latestShipmentStatus": "In Transit at Post office",
        "statusDate": "2023-05-03T14:31:11.23"
    },
    {
        "trackingNumber": "398165423250",
        "shipmentDate": "2023-05-11T09:31:19",
        "latestShipmentStatus": "Customs Cleared",
        "statusDate": "2023-05-14T05:26:56.84"
    },
    {
        "trackingNumber": "9200190287129905127592",
        "shipmentDate": "2023-04-30T21:43:12",
        "latestShipmentStatus": "Parcel Out For Delivery",
        "statusDate": "2023-05-03T14:31:11.23"
    },
    {
        "trackingNumber": "9200190287129905127608",
        "shipmentDate": "2023-04-30T21:44:02",
        "latestShipmentStatus": "Parcel Out For Delivery",
        "statusDate": "2023-05-03T14:31:11.23"
    },
    {
        "trackingNumber": "WZM0001071269",
        "shipmentDate": "2023-04-30T21:40:52",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-03T18:15:45.58"
    },
    {
        "trackingNumber": "WZM0001071252",
        "shipmentDate": "2023-04-30T21:34:58",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-03T19:45:59.08"
    },
    {
        "trackingNumber": "9261290111591014925455",
        "shipmentDate": "2023-04-30T22:32:00",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-03T20:01:18.433"
    },
    {
        "trackingNumber": "9400136106074760623456",
        "shipmentDate": "2023-04-30T21:36:41",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-04T18:40:27.773"
    },
    {
        "trackingNumber": "9200190287129905127585",
        "shipmentDate": "2023-04-30T21:42:42",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-04T22:01:07.99"
    },
    {
        "trackingNumber": "9200190287129905127592",
        "shipmentDate": "2023-04-30T21:43:12",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-03T21:16:07.627"
    },
    {
        "trackingNumber": "WZM0001071245",
        "shipmentDate": "2023-04-30T21:25:31",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-04T18:15:40.25"
    },
    {
        "trackingNumber": "9274890278832026104675",
        "shipmentDate": "2023-04-30T23:54:37",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-10T13:01:11.587"
    },
    {
        "trackingNumber": "9200190287129905127608",
        "shipmentDate": "2023-04-30T21:44:02",
        "latestShipmentStatus": "Parcel Delivered",
        "statusDate": "2023-05-03T14:31:11.23"
    },
    {
        "trackingNumber": "9274890278832026104668",
        "shipmentDate": "2023-04-30T23:50:24",
        "latestShipmentStatus": "Cancelled",
        "statusDate": "2023-04-30T19:51:31.53"
    }
]
