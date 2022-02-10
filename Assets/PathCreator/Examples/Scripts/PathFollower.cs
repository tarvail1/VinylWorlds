using System;
using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public static PathFollower PathFollowerInstance;
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;
        float distanceTravelled;
        public float objectOffset;
        public float multiplier;
        public FloatVariable multiplierValue;

        void Start() {
            if (pathCreator != null)
            {
                
                
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        private void Awake()
        {
            distanceTravelled += objectOffset;
        }

        void Update()
        {

            if (pathCreator != null)
            {
                distanceTravelled += speed * Time.deltaTime * (multiplier+speed);
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
            }

            if (Input.GetMouseButton(0))
            {
                float Yaxis = Input.GetAxis("Mouse Y");
                Yaxis = Yaxis * -1;
                multiplier = (float) Yaxis*5;
                multiplierValue.SetValue(multiplier);

            }

        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = objectOffset * pathCreator.path.GetClosestDistanceAlongPath(transform.position);
            
            
        }
    }
}