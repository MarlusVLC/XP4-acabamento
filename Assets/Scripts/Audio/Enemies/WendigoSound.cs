using UnityEngine;

namespace Audio
{
    public class WendigoSound : AudioManager
    {
        public void PlayAttackSound()
        {
            var index = Random.Range(0, 3);
            Play(index);
        }

        public void PlayDeathSound()
        {
            var index = Random.Range(4, 7);
            Play(index);
        }
        
        public void PlayAlertSound()
        {
            var index = Random.Range(8, 11);
            Play(index);
        }

        public void PlayDamageSound()
        {
            var index = Random.Range(12, 15);
            Play(index);
        }

        public void PlayChaseSound()
        {
            var index = Random.Range(16, 19);
            Play(index);
        }

        public void PlaySound(EnemyActionType actionType)
        {
            switch (actionType)
            {
                case EnemyActionType.Attack:
                    PlayAttackSound();
                    break;
                case EnemyActionType.Alert:
                    PlayAlertSound();
                    break;
                case EnemyActionType.Chase:
                    PlayChaseSound();
                    break;
                case EnemyActionType.Damage:
                    PlayDamageSound();
                    break;
                case EnemyActionType.Death:
                    PlayDeathSound();
                    break;
            }
        }
    }
}