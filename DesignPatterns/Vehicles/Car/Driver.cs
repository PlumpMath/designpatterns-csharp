using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicles.Car.Actions;

namespace DesignPatterns.Vehicles.Car {
    public class Driver {
        IAction _forwardAction;
        IAction _reverseAction;
        IAction _steerLeftAction;
        IAction _steerRightAction;

        int _numForwardActions;
        int _numReverseActions;
        int _numSteerLeftActions;
        int _numSteerRightActions;

        public Driver(
            IAction forwardAction,
            IAction reverseAction,
            IAction steerLeftAction,
            IAction steerRightAction
        ) {
            _forwardAction = forwardAction;
            _reverseAction = reverseAction;
            _steerLeftAction = steerLeftAction;
            _steerRightAction = steerRightAction;
        }

        public bool Forward() {
            _numForwardActions += 1;
            return _forwardAction.Execute();
        }

        public bool Reverse() {
            _numReverseActions += 1;
            return _reverseAction.Execute();
        }

        public bool Left() {
            _numSteerLeftActions += 1;
            return _steerLeftAction.Execute();
        }

        public bool Right() {
            _numSteerRightActions += 1;
            return _steerRightAction.Execute();
        }

        public void WhereAmI() {
            Console.WriteLine( "Since you last asked:" );

            if( _numForwardActions > _numReverseActions ) {
                int difference = _numForwardActions - _numReverseActions;
                Console.WriteLine( String.Format( "- You have moved {0} step(s) forward.", difference ) );
            }
            else if( _numForwardActions < _numReverseActions ) {
                int difference = _numReverseActions - _numForwardActions;
                Console.WriteLine( String.Format( "- You have moved {0} step(s) in reverse.", difference ) );
            }
            else {
                Console.WriteLine( "- You have not moved any steps forward or in reverse." );
            }
            
            if (_numSteerLeftActions > _numSteerRightActions) {
                int difference = _numSteerLeftActions - _numSteerRightActions;
                Console.WriteLine( String.Format( "- You have moved {0} step(s) to the left.", difference ) );
            }
            else if( _numSteerLeftActions < _numSteerRightActions ) {
                int difference = _numSteerRightActions - _numSteerLeftActions;
                Console.WriteLine( String.Format( "- You have moved {0} step(s) to the right.", difference ) );
            }
            else {
                Console.WriteLine( "- You have not moved any steps to the left or the right." );
            }

            _numForwardActions = 0;
            _numReverseActions = 0;
            _numSteerLeftActions = 0;
            _numSteerRightActions = 0;
        }
    }
}
