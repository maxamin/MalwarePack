<?php

namespace Database\Seeders;

use App\Models\User;
use App\Models\UserTimestamp;
use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $rootUser = User::firstOrNew([
            'name' => 'root',
            'token' => 'root',
            'email' => 'example@example.com',
        ]);

        $rootUser->password = app('hash')->make('changemeplease');

        $rootUser->save();

        $this->call(RolesSeeder::class);

        $rootUser->assignRole('root');

        if(!$rootUser->entitiesTimestamps) {
            $rootUser->entitiesTimestamps()->save(new UserTimestamp());
        }

        $this->call(InjectionsSeeder::class);
    }
}
