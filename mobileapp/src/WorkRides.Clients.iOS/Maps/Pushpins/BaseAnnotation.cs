using CoreLocation;
using MapKit;

namespace CarPool.Clients.iOS.Maps.Pushpins
{
    public abstract class BaseAnnotation : MKAnnotation
    {
        private CLLocationCoordinate2D _coordinate;

        public override CLLocationCoordinate2D Coordinate
        {
            get
            {
                return _coordinate;
            }
        }

        protected BaseAnnotation(CLLocationCoordinate2D coordinate)
        {
            _coordinate = coordinate;
        }

        public override void SetCoordinate(CLLocationCoordinate2D coordinate)
        {
			WillChangeValue("coordinate");
            _coordinate = coordinate;
			DidChangeValue("coordinate");
        }
    }
}