﻿namespace CensusCore.Events
{
    using CensusAPI.Features;
    using EventArgs.Player;
    using System;
    using UnityEngine;
    using VirtualBrightPlayz.SCP_ET.NPCs.Interfaces;
    using VirtualBrightPlayz.SCP_ET.Player;

    public class CensusPlayerEvents
    {
        public CensusPlayerEvents()
        {
            Instance = this;
        }

        public static CensusPlayerEvents Instance { get; private set; }

        public static event Hurt HurtEvent;

        public delegate void Hurt(HurtEventArgs ev);

        public void ExecuteHurt(HurtEventArgs ev)
        {
            try
            {
                HurtEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling HurtEvent: {e}");
            }
        }

        public static event Dying DyingEvent;

        public delegate void Dying(DyingEventArgs ev);

        public void ExecuteDying(DyingEventArgs ev)
        {
            try
            {
                DyingEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling DyingEvent: {e}");
            }
        }

        public static event Died DiedEvent;

        public delegate void Died(DiedEventArgs ev);

        public void ExecuteDied(DiedEventArgs ev)
        {
            try
            {
                DiedEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling DiedEvent: {e}");
            }
        }

        public static void InvokeDied(PlayerController player, PlayerStats.DeathTypes death, GameObject killer)
        {
            DiedEventArgs ev = new DiedEventArgs(player, death, killer == null ? null : killer.GetComponent<IEntity>());
            Instance.ExecuteDied(ev);
        }

        public static event PickingUpItem PickingUpItemEvent;

        public delegate void PickingUpItem(PickingUpItemEventArgs ev);

        public void ExecutePickingUpItem(PickingUpItemEventArgs ev)
        {
            try
            {
                PickingUpItemEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling PickingUpItemEvent: {e}");
            }
        }

        public static event CraftingItem CraftingItemEvent;

        public delegate void CraftingItem(CraftingItemEventArgs ev);

        public void ExecuteCraftingItem(CraftingItemEventArgs ev)
        {
            try
            {
                CraftingItemEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling CraftingItemEvent: {e}");
            }
        }

        public static event UsingFemurBreaker UsingFemurBreakerEvent;

        public delegate void UsingFemurBreaker(UsingFemurBreakerEventArgs ev);

        public void ExecuteUsingFemurBreaker(UsingFemurBreakerEventArgs ev)
        {
            try
            {
                UsingFemurBreakerEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling UsingFemurBreakerEvent: {e}");
            }
        }

        public static event InteractingDoorButton InteractingDoorButtonEvent;

        public delegate void InteractingDoorButton(InteractingDoorButtonEventArgs ev);

        public void ExecuteInteractingDoorButton(InteractingDoorButtonEventArgs ev)
        {
            try
            {
                InteractingDoorButtonEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling InteractingDoorButtonEvent: {e}");
            }
        }

        public static event Interacting1123 Interacting1123Event;

        public delegate void Interacting1123(Interacting1123EventArgs ev);

        public void ExecuteInteracting1123(Interacting1123EventArgs ev)
        {
            try
            {
                Interacting1123Event?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling Interacting1123Event: {e}");
            }
        }

        public static event Blinking BlinkingEvent;

        public delegate void Blinking(BlinkingEventArgs ev);

        public void ExecuteBlinking(BlinkingEventArgs ev)
        {
            try
            {
                BlinkingEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling BlinkingEvent: {e}");
            }
        }

        public static event DroppingItem DroppingItemEvent;

        public delegate void DroppingItem(DroppingItemEventArgs ev);

        public void ExecuteDroppingItem(DroppingItemEventArgs ev)
        {
            try
            {
                DroppingItemEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling DroppingItemEvent: {e}");
            }
        }

        public static event EnteringPocketDimension EnteringPocketDimensionEvent;

        public delegate void EnteringPocketDimension(EnteringPocketDimensionEventArgs ev);

        public void ExecuteEnteringPocketDimension(EnteringPocketDimensionEventArgs ev)
        {
            try
            {
                EnteringPocketDimensionEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling EnteringPocketDimensionEvent: {e}");
            }
        }

        public static event EquipingItem EquipingItemEvent;

        public delegate void EquipingItem(EquipingItemEventArgs ev);

        public void ExecuteEquipingItem(EquipingItemEventArgs ev)
        {
            try
            {
                EquipingItemEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling EquipingItemEvent: {e}");
            }
        }

        public static event EscapingPocketDimension EscapingPocketDimensionEvent;

        public delegate void EscapingPocketDimension(EscapingPocketDimensionEventArgs ev);

        public void ExecuteEscapingPocketDimension(EscapingPocketDimensionEventArgs ev)
        {
            try
            {
                EscapingPocketDimensionEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling EscapingPocketDimensionEvent: {e}");
            }
        }

        public static event FailingToEscapePocketDimension FailingToEscapePocketDimensionEvent;

        public delegate void FailingToEscapePocketDimension(FailingToEscapePocketDimensionEventArgs ev);

        public void ExecuteFailingToEscapePocketDimension(FailingToEscapePocketDimensionEventArgs ev)
        {
            try
            {
                FailingToEscapePocketDimensionEvent?.Invoke(ev);
            }
            catch (Exception e)
            {
                Log.Error($"Exception while handling FailingToEscapePocketDimensionEvent: {e}");
            }
        }

    }
}