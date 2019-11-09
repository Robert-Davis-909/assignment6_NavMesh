# assignment06 #
## Scene 1 ##
1. Start with an empty project and get the NavMesh Components from <https://github.com/Unity-Technologies/NavMeshComponents/tree/master>
   * Clone or download the repository and open the project in Unity. Alternatively, you can copy the contents of Assets/NavMeshComponents to an existing project. 
2. Create a plane and place some blocks on the ground. Increase the position y to 0.5 to get them on (not in) the ground. Group them under an empty game object Obstacles.
3. To the Obstacles group, add a NavMeshModifier component , check "override area", and  set area type to non-walkable. Now the obstacles can not be navigated.
4. Create an empty game object NavigationMesh, add the NavMeshSurface component to it
5. Create a player (cylinder),  set the position y to 1 so it is on the ground, create a layer "player" in the inspector and assign that to the player.
6. In the NavigationMesh inspector, NavMeshSurface, exclude the player layer
7. Add a NavMeshAgent component to the player
8. Add the [Player Controller Script](https://github.com/bekkerin/assignment06/blob/master/NavMesh%20Example%20Project/Assets/PlayerController.cs  ) to the Player. Drop the main camera in the cam slot, and the Player in the Agent slot (the Player has the NavMeshAgent as component, you can also drop the NavMeshAgent component itself in the slot)
9. if you want to, increase the camera y-coordinate and rotate the camera x-axis to get more of a top view
10. You are ready to play

Expansion: add the [Nature Starter Kit](https://assetstore.unity.com/packages/3d/environments/nature-starter-kit-1-49962) to the project. Open the demo scene in the kit, and add a navigation mesh and player. 

## Scene 2 ##
1. Start with an empty project and create a plane.  Add a cylinder as the player, set its y position to 1 to keep it on (not in) the ground.
2. In the player, create a player layer and assign it to the layer of the player.
3. Add an empty game object NavigationMesh and add a NavMeshSurface component  to make the plane navigable. Exclude the player layer from the NavMeshSurface script and bake
4. Add a NavMeshAgent to the cylinder/player to enable him to use the NavMesh
5. Add an empty game object NonNavigable and add a NavMeshModifierVolume component so we can remove some area from the navigable area by setting it as non walkable. Adjust the size by clicking Edit Volume. Bake the NavMesh.
6. Create a couple of cubes and group them to an empty Obstacles game object (in Example02, simply enable the objects)
7. To the obstacles, add the NavMeshObstacle component (either as group, or individually if you want to adjust individual sizes)
8. With carve unselected, in the NavMeshObstacle, we only have obstacle avoidance. With carve selected, it cuts out a piece of the NavMesh and it includes the obstacle in the path finding (make sure to disable "carve only stationary" which shows when you enable carve).
9. Add the ObstacleAnimation script to the obstacles (group or individual if you want to adjust individual speeds)
10. Add the PlayerController script to the player and drop the camera and player in the slots of the script.
11. Give the obstacles a rigidbody so it does not go through the obstacles
12. Bake the NavMesh and play.
